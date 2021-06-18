﻿/*
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

        private float _rotatorAngle = 0.0f;
        private bool _rotatorIsMoving = false;

        #endregion

        #region Colors

        private Color _textboxBnormal = Color.Silver;
        private Color _textboxBerror = Color.LightSalmon;

        #endregion
        public FormMain()
        {
            InitializeComponent();
            UpdateAscomDeviceLabels();
            _rotatorId = Properties.Settings.Default["RotatorId"].ToString();
            UpdateAscomDeviceLabels();
            EnableRotatorControls(false);

            rotatorGauge.MinValue = 0;
            rotatorGauge.MaxValue = 360;
            rotatorGauge.Glossiness = 12;
            rotatorGauge.Value = 50;
        }

        #region ASCOM
     
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
            string visibleText = _rotatorId;
            if (visibleText.Length > 32)
                visibleText = visibleText.Substring(0, 32) + "...";
            labelRotator.Text = visibleText;
        }

        
        private void buttonChooseRotator_Click(object sender, EventArgs e)
        {
            _rotatorId = Rotator.Choose(_rotatorId);
            UpdateAscomDeviceLabels();
            Properties.Settings.Default["RotatorId"] = _rotatorId;
            Properties.Settings.Default.Save();
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
                if (_rotator != null)
                    _rotator.Dispose();
                _rotator = null;
                this.buttonRotatorConnect.Image = global::OAGSeeker.Properties.Resources.Off;
                EnableRotatorControls(false);
            }
        }

        #endregion

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
                float rotAng = 0.0f;
                try
                {
                    rotAng = (float)Convert.ToDouble(textBoxMoveTo.Text, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    textBoxMoveTo.Text = "0.0";
                    return;
                }

                _rotator.MoveAbsolute(rotAng);
                _rotatorAngle = rotAng;
            }
        }

        private void timerPosition_Tick(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            labelAngle.Text = _rotator.Position.ToString(CultureInfo.InvariantCulture) + " °";
            _rotatorAngle = _rotator.Position;
            rotatorGauge.Value = _rotatorAngle;
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

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            if (_rotatorIsMoving) return;
            _rotator.Move(-2.0f);
           
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (_rotator == null) return;
            if (_rotatorIsMoving) return;
            _rotator.Move(2.0f);
            
        }

        
    }
}
