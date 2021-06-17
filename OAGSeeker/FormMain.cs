/*
 *  Copyright 2021, Othmar Ehrhardt <othmar.ehrhardt@t-online.de>, 
 *                  https://astro.stroblhof-oberrohrbach.de
 * 
 *  This file is part of the TelescopeMountBackslashMeasurement project.
 *
 *  TelescopeMountBackslashMeasurement is licensed under the Code Project Open License (CPOL) 1.02.
 *  
 *  You should have received a copy of the CPOL License
 *  along with TelescopeMountBackslashMeasurement.  If not, see <https://www.codeproject.com/info/cpol10.aspx>.
 * 
 * 
 * Some code used from:
 * PictureBox, JohnWillemse <https://www.codeproject.com/Articles/21097/PictureBox-Zoom>
 * 30 Oct 2007, CPOL
 * void ResizeAndDisplayImage(), void UpdateZoomedImage(MouseEventArgs e),  
 * void picImage_MouseMove(object sender, MouseEventArgs e), void trbZoomFactor_ValueChanged(object sender, EventArgs e)
 *
 */

using ASCOM.DriverAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAGSeeker
{
    public partial class FormMain : Form
    {
        #region Properties

        private string _cameraId = "ASCOM.Simulator.Camera";
        private string _rotatorId = "";
        private Camera _camera = null;
        private Rotator _rotator = null;
        private double _exposure = 1.5;
        private int _stretchFactor = 256;
        private double _resolution = 0.0;

        private int _ZoomFactor = 1;
        private Color _BackColor;
        private Image _OriginalImage = null;
        private Image _WorkingImage = null;

        private float _rotatorAngle = 0;
        private bool _rotatorIsMoving = false;

        #endregion

        #region Colors

        private Color _textboxBnormal = Color.Silver;
        private Color _textboxBerror = Color.LightSalmon;

        #endregion
        public FormMain()
        {
            InitializeComponent();
            panelScrollArea.Controls.Add(picImage);
            UpdateAscomDeviceLabels();
            backgroundWorkerExposure.DoWork += BackgroundWorkerExposure_DoWork;

            //_ZoomFactor = trbZoomFactor.Value;
            _BackColor = picImage.BackColor;

            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            
            // Reload settings
            _exposure = (double)Properties.Settings.Default["LastExposure"];
            textBoxExposure.Text = _exposure.ToString(System.Globalization.CultureInfo.InvariantCulture);
            _cameraId = Properties.Settings.Default["CameraId"].ToString();
            _rotatorId = Properties.Settings.Default["RotatorId"].ToString();

            UpdateAscomDeviceLabels();
            EnableCameraControls(false);
            EnableRotatorControls(false);
            _OriginalImage = Bitmap.FromFile("Beteigeuze_Spectrum_-20.00_0.30s_0000.png");
            _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
            ResizeAndDisplayImage();
        }

        #region ASCOM
        private void EnableCameraControls(bool en)
        {
            textBoxExposure.Enabled = en;
            buttonExposure.Enabled = en;
            if (en)
            {
                labelPixelsize.Text = _camera.PixelSizeX.ToString(System.Globalization.CultureInfo.InvariantCulture) + " µm";
            }
            else
            {
                labelPixelsize.Text = "...";
            }
        }


        private void EnableRotatorControls(bool en)
        {
            if (en == true)
            {
                _rotatorAngle = _rotator.Position;
                buttonRotateStep.Enabled = true;
                buttonRotateZero.Enabled = true;
            }
            else
            {
                buttonRotateStep.Enabled = false;
                buttonRotateZero.Enabled = false;
            }
        }
     
        private void UpdateAscomDeviceLabels()
        {
            string visibleText = _cameraId;
            if (visibleText.Length > 32)
                visibleText = visibleText.Substring(0, 32) + "...";
            labelCamera.Text = visibleText;

            visibleText = _rotatorId;
            if (visibleText.Length > 32)
                visibleText = visibleText.Substring(0, 32) + "...";
            labelRotator.Text = visibleText;
        }

        private void buttonChooseCamera_Click(object sender, EventArgs e)
        {
            _cameraId = Camera.Choose(_cameraId);
            UpdateAscomDeviceLabels();
            Properties.Settings.Default["CameraId"] = _cameraId;
            Properties.Settings.Default.Save();
            
        }

        private void buttonChooseRotator_Click(object sender, EventArgs e)
        {
            _rotatorId = Rotator.Choose(_rotatorId);
            UpdateAscomDeviceLabels();
            Properties.Settings.Default["RotatorId"] = _rotatorId;
            Properties.Settings.Default.Save();
        }

        private void buttonCameraConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_camera == null)
                {
                    _camera = new Camera(_cameraId);
                    _camera.Connected = true;
                    if (_camera.Connected)
                    {
                        this.buttonCameraConnect.Image = global::OAGSeeker.Properties.Resources.On;
                        _stretchFactor = (_camera.MaxADU / 256) + 1;
                        EnableCameraControls(true);
                        if (_camera.MaxBinX >= 2)
                        {
                            _camera.BinX = 2;
                            _camera.NumX = _camera.NumX / 2;
                        }
                        if (_camera.MaxBinY >= 2)
                        {
                            _camera.BinY = 2;
                            _camera.NumY = _camera.NumY / 2;
                        }
                    }
                    else
                    {
                        EnableCameraControls(false);
                        _camera.Dispose();
                        _camera = null;
                    }
                }
                else
                {
                    _camera.Connected = false;
                    _camera.Dispose();
                    _camera = null;
                    this.buttonCameraConnect.Image = global::OAGSeeker.Properties.Resources.Off;
                    EnableCameraControls(false);
                }
            } catch (Exception ex)
            {
                if (_camera != null)
                    _camera.Dispose();
                _camera = null;
                this.buttonCameraConnect.Image = global::OAGSeeker.Properties.Resources.Off;
                EnableCameraControls(false);
            }
        }

        private void buttonRotatorConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rotator == null)
                {
                    _rotator = new Rotator(_rotatorId);
                    _rotator.Connected = true;
                    if (_rotator.Connected)
                    {
                        this.buttonRotatorConnect.Image = global::OAGSeeker.Properties.Resources.On;
                        EnableRotatorControls(true);
                    }
                    else
                    {
                        EnableRotatorControls(false);
                        _rotator.Dispose();
                        _rotator = null;
                    }
                }
                else
                {
                    _rotator.Connected = false;
                    _rotator.Dispose();
                    _rotator = null;
                    this.buttonRotatorConnect.Image = global::OAGSeeker.Properties.Resources.Off;
                    EnableRotatorControls(false);
                }
            }
            catch (Exception ex)
            {
                if (_camera != null)
                    _camera.Dispose();
                _camera = null;
                this.buttonCameraConnect.Image = global::OAGSeeker.Properties.Resources.Off;
                EnableCameraControls(false);
            }
        }

        #endregion

        #region Camera Image
        private void DisplayImage(int[,] array)
        {
            int w = array.GetUpperBound(0) + 1;
            int h = array.GetUpperBound(1) + 1;
            _OriginalImage = fromTwoDimIntArrayGray(array);
            _WorkingImage = (System.Drawing.Image)_OriginalImage.Clone();
            ResizeAndDisplayImage();
        }

        // Conversion from array to bitmap: some code from Nyerguds, <https://stackoverflow.com/questions/49046376/turning-int-array-into-bmp-in-c-sharp>
        public Bitmap fromTwoDimIntArrayGray(Int32[,] data)
        {
            Int32 width = data.GetLength(0);
            Int32 height = data.GetLength(1);
            Int32 stride = width * 4;
            Int32 byteIndex = 0;
            Byte[] dataBytes = new Byte[height * stride];
            for (Int32 y = 0; y < height; y++)
            {
                for (Int32 x = 0; x < width; x++)
                {
                    // UInt32 0xAARRGGBB = Byte[] { BB, GG, RR, AA }
                    Byte val = (Byte)(((UInt32)data[x, y]) / _stretchFactor);
                    // This code clears out everything but a specific part of the value
                    // and then shifts the remaining piece down to the lowest byte
                    dataBytes[byteIndex + 0] = val; // B
                    dataBytes[byteIndex + 1] = val; // G
                    dataBytes[byteIndex + 2] = val; // R
                    dataBytes[byteIndex + 3] = 255; // A
                                                                                 // More efficient than multiplying
                    byteIndex += 4;
                }
            }
            return BuildImage(dataBytes, width, height, stride, PixelFormat.Format32bppArgb, null, null);
        }

        public Bitmap BuildImage(Byte[] sourceData, Int32 width, Int32 height, Int32 stride, PixelFormat pixelFormat, Color[] palette, Color? defaultColor)
        {
            Bitmap newImage = new Bitmap(width, height, pixelFormat);
            BitmapData targetData = newImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, newImage.PixelFormat);
            Int32 newDataWidth = ((Image.GetPixelFormatSize(pixelFormat) * width) + 7) / 8;
            // Compensate for possible negative stride on BMP format.
            Boolean isFlipped = stride < 0;
            stride = Math.Abs(stride);
            // Cache these to avoid unnecessary getter calls.
            Int32 targetStride = targetData.Stride;
            Int64 scan0 = targetData.Scan0.ToInt64();
            for (Int32 y = 0; y < height; y++)
                Marshal.Copy(sourceData, y * stride, new IntPtr(scan0 + y * targetStride), newDataWidth);
            newImage.UnlockBits(targetData);
            // Fix negative stride on BMP format.
            if (isFlipped)
                newImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            // For indexed images, set the palette.
            if ((pixelFormat & PixelFormat.Indexed) != 0 && palette != null)
            {
                ColorPalette pal = newImage.Palette;
                for (Int32 i = 0; i < pal.Entries.Length; i++)
                {
                    if (i < palette.Length)
                        pal.Entries[i] = palette[i];
                    else if (defaultColor.HasValue)
                        pal.Entries[i] = defaultColor.Value;
                    else
                        break;
                }
                newImage.Palette = pal;
            }
            return newImage;
        }

        private void BackgroundWorkerExposure_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_camera == null) return;
            if (!_camera.Connected) return;
            this.Invoke((MethodInvoker)delegate
            {
                this.buttonExposure.Image = global::OAGSeeker.Properties.Resources.Stop;
            });
            _camera.StartExposure(_exposure, true);
            while (!_camera.ImageReady)
            {
                Thread.Sleep(50);
            }
            int[,] imgArray = (int[,])_camera.ImageArray;
            this.Invoke((MethodInvoker)delegate
            {
                this.buttonExposure.Image = global::OAGSeeker.Properties.Resources.Exposure;
                DisplayImage(imgArray);
            });
            
        }

        private void buttonExposure_Click(object sender, EventArgs e)
        {
            string expTime = textBoxExposure.Text;
            expTime = expTime.Replace(",", ".");
            textBoxExposure.Text = expTime;
            if (!double.TryParse(expTime, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out _exposure))
            {
                textBoxExposure.BackColor = _textboxBerror;
                return;
            }
            textBoxExposure.BackColor = _textboxBnormal;
            Properties.Settings.Default["LastExposure"] = _exposure;
            Properties.Settings.Default.Save();
            backgroundWorkerExposure.RunWorkerAsync();
        }
        #endregion

        #region Private Methods from PictureBox

        /// <summary>
        /// Resizes the image stored in _OriginalImage to fit in picImage,
        /// maintaining the aspect ratios and displays it.
        /// </summary>
        private void ResizeAndDisplayImage()
        {
            // Set the backcolor of the pictureboxes
            picImage.BackColor = _BackColor;

            // If _OriginalImage is null, then return. This situation can occur
            // when a new backcolor is selected without an image loaded.
            if (_WorkingImage == null)
                return;

            picImage.Image = _WorkingImage;

            Graphics gr = Graphics.FromImage(_WorkingImage);
            gr.CompositingMode = CompositingMode.SourceCopy;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            Pen referencePen = new Pen(new SolidBrush(Color.Yellow));
            Pen measurePen = new Pen(new SolidBrush(Color.Green));
            gr.Dispose();
            //return;
            // sourceWidth and sourceHeight store the original image's width and height
            // targetWidth and targetHeight are calculated to fit into the picImage picturebox.
            int sourceWidth = _WorkingImage.Width;
            int sourceHeight = _WorkingImage.Height;
            int targetWidth;
            int targetHeight;
            double ratio;

            // Calculate targetWidth and targetHeight, so that the image will fit into
            // the picImage picturebox without changing the proportions of the image.
            if (sourceWidth > sourceHeight)
            {
                // Set the new width
                targetWidth = picImage.Width;
                // Calculate the ratio of the new width against the original width
                ratio = (double)targetWidth / sourceWidth;
                // Calculate a new height that is in proportion with the original image
                targetHeight = (int)(ratio * sourceHeight);
            }
            else if (sourceWidth < sourceHeight)
            {
                // Set the new height
                targetHeight = picImage.Height;
                // Calculate the ratio of the new height against the original height
                ratio = (double)targetHeight / sourceHeight;
                // Calculate a new width that is in proportion with the original image
                targetWidth = (int)(ratio * sourceWidth);
            }
            else
            {
                // In this case, the image is square and resizing is easy
                targetHeight = picImage.Height;
                targetWidth = picImage.Width;
            }

            // Calculate the targetTop and targetLeft values, to center the image
            // horizontally or vertically if needed
            int targetTop = (picImage.Height - targetHeight) / 2;
            int targetLeft = (picImage.Width - targetWidth) / 2;

            // Create a new temporary bitmap to resize the original image
            // The size of this bitmap is the size of the picImage picturebox.
            Bitmap tempBitmap = new Bitmap(picImage.Width, picImage.Height, PixelFormat.Format32bppRgb);

            // Set the resolution of the bitmap to match the original resolution.
            tempBitmap.SetResolution(_WorkingImage.HorizontalResolution, _WorkingImage.VerticalResolution);

            // Create a Graphics object to further edit the temporary bitmap
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);

            // First clear the image with the current backcolor
            bmGraphics.Clear(_BackColor);

            // Set the interpolationmode since we are resizing an image here
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the original image on the temporary bitmap, resizing it using
            // the calculated values of targetWidth and targetHeight.
            bmGraphics.DrawImage(_WorkingImage,
                                 new Rectangle(targetLeft, targetTop, targetWidth, targetHeight),
                                 new Rectangle(0, 0, sourceWidth, sourceHeight),
                                 GraphicsUnit.Pixel);

            // Dispose of the bmGraphics object
            bmGraphics.Dispose();

            // Set the image of the picImage picturebox to the temporary bitmap
            picImage.Image = tempBitmap;
        }

        /// <summary>
        /// Updates the picZoom image to show the portion of the main image
        /// the mouse is currently over.
        /// </summary>
       

        #endregion // Private Methods

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            // If no picture is loaded, return
            if (picImage.Image == null)
                return;
        }

        private void buttonRotateZero_Click(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            if (_rotator.IsMoving)
            {
                _rotator.Halt();
                _rotatorAngle = _rotator.Position;
            }
            else
            {
                this.buttonRotateZero.Image = global::OAGSeeker.Properties.Resources.Stop;
                this.buttonRotateStep.Image = global::OAGSeeker.Properties.Resources.Stop;
                _rotator.MoveAbsolute(0.0f);
                _rotatorAngle = 0.0f;
            }
        }

        private void timerPosition_Tick(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            labelAngle.Text = _rotator.Position.ToString(CultureInfo.InvariantCulture) + " °";
        }

        private void timerIsRotatorMoving_Tick(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            if(_rotator.IsMoving)
            {
                _rotatorIsMoving = true;
            }
            else
            {
                _rotatorIsMoving = false;
                this.buttonRotateZero.Image = global::OAGSeeker.Properties.Resources.RotateZero;
                this.buttonRotateStep.Image = global::OAGSeeker.Properties.Resources.Rotate;
            }
        }

        private void buttonRotateStep_Click(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            if (_rotator.IsMoving)
            {
                _rotator.Halt();
                _rotatorAngle = _rotator.Position;
            }
            else
            {
                this.buttonRotateZero.Image = global::OAGSeeker.Properties.Resources.Stop;
                this.buttonRotateStep.Image = global::OAGSeeker.Properties.Resources.Stop;
                float rotStep = 0.0f;
                try
                {
                    rotStep = (float)Convert.ToDouble(textBoxRotationStep.Text, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    textBoxRotationStep.Text = "10.0";
                    return;
                }
                _rotatorAngle = _rotatorAngle + rotStep;
                if (_rotatorAngle > 360.0) return;
                _rotator.MoveAbsolute(_rotatorAngle);
            }

        }
    }
}
