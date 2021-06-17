
namespace OAGSeeker
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonChooseCamera = new System.Windows.Forms.Button();
            this.labelCamera = new System.Windows.Forms.Label();
            this.textBoxExposure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerExposure = new System.ComponentModel.BackgroundWorker();
            this.labelRotator = new System.Windows.Forms.Label();
            this.buttonChooseRotator = new System.Windows.Forms.Button();
            this.labelPixelsize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelScrollArea = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.buttonRotatorConnect = new System.Windows.Forms.Button();
            this.buttonExposure = new System.Windows.Forms.Button();
            this.buttonCameraConnect = new System.Windows.Forms.Button();
            this.textBoxRotationStep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRotateZero = new System.Windows.Forms.Button();
            this.buttonRotateStep = new System.Windows.Forms.Button();
            this.labelAngle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerPosition = new System.Windows.Forms.Timer(this.components);
            this.timerIsRotatorMoving = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelScrollArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChooseCamera
            // 
            this.buttonChooseCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseCamera.BackColor = System.Drawing.Color.Teal;
            this.buttonChooseCamera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCamera.Location = new System.Drawing.Point(328, 14);
            this.buttonChooseCamera.Name = "buttonChooseCamera";
            this.buttonChooseCamera.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseCamera.TabIndex = 0;
            this.buttonChooseCamera.Text = "...";
            this.buttonChooseCamera.UseVisualStyleBackColor = false;
            this.buttonChooseCamera.Click += new System.EventHandler(this.buttonChooseCamera_Click);
            // 
            // labelCamera
            // 
            this.labelCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCamera.AutoSize = true;
            this.labelCamera.Location = new System.Drawing.Point(146, 19);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCamera.Size = new System.Drawing.Size(177, 13);
            this.labelCamera.TabIndex = 1;
            this.labelCamera.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // textBoxExposure
            // 
            this.textBoxExposure.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxExposure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExposure.Location = new System.Drawing.Point(13, 54);
            this.textBoxExposure.Name = "textBoxExposure";
            this.textBoxExposure.Size = new System.Drawing.Size(100, 19);
            this.textBoxExposure.TabIndex = 3;
            this.textBoxExposure.Text = "1.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure [s]:";
            // 
            // labelRotator
            // 
            this.labelRotator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRotator.AutoSize = true;
            this.labelRotator.Location = new System.Drawing.Point(146, 54);
            this.labelRotator.Name = "labelRotator";
            this.labelRotator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRotator.Size = new System.Drawing.Size(177, 13);
            this.labelRotator.TabIndex = 10;
            this.labelRotator.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // buttonChooseRotator
            // 
            this.buttonChooseRotator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseRotator.BackColor = System.Drawing.Color.Teal;
            this.buttonChooseRotator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseRotator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseRotator.Location = new System.Drawing.Point(329, 51);
            this.buttonChooseRotator.Name = "buttonChooseRotator";
            this.buttonChooseRotator.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseRotator.TabIndex = 9;
            this.buttonChooseRotator.Text = "...";
            this.buttonChooseRotator.UseVisualStyleBackColor = false;
            this.buttonChooseRotator.Click += new System.EventHandler(this.buttonChooseRotator_Click);
            // 
            // labelPixelsize
            // 
            this.labelPixelsize.AutoSize = true;
            this.labelPixelsize.Location = new System.Drawing.Point(69, 80);
            this.labelPixelsize.Name = "labelPixelsize";
            this.labelPixelsize.Size = new System.Drawing.Size(16, 13);
            this.labelPixelsize.TabIndex = 21;
            this.labelPixelsize.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pixelsize:";
            // 
            // panelScrollArea
            // 
            this.panelScrollArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScrollArea.AutoScroll = true;
            this.panelScrollArea.Controls.Add(this.picImage);
            this.panelScrollArea.Location = new System.Drawing.Point(129, 99);
            this.panelScrollArea.Name = "panelScrollArea";
            this.panelScrollArea.Size = new System.Drawing.Size(502, 423);
            this.panelScrollArea.TabIndex = 26;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(363, 530);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            this.picImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseMove);
            // 
            // buttonRotatorConnect
            // 
            this.buttonRotatorConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRotatorConnect.BackColor = System.Drawing.Color.Teal;
            this.buttonRotatorConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotatorConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotatorConnect.Image = global::OAGSeeker.Properties.Resources.Off;
            this.buttonRotatorConnect.Location = new System.Drawing.Point(375, 51);
            this.buttonRotatorConnect.Name = "buttonRotatorConnect";
            this.buttonRotatorConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonRotatorConnect.TabIndex = 11;
            this.buttonRotatorConnect.UseVisualStyleBackColor = false;
            this.buttonRotatorConnect.Click += new System.EventHandler(this.buttonRotatorConnect_Click);
            // 
            // buttonExposure
            // 
            this.buttonExposure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExposure.BackColor = System.Drawing.Color.Teal;
            this.buttonExposure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExposure.ForeColor = System.Drawing.Color.Silver;
            this.buttonExposure.Image = ((System.Drawing.Image)(resources.GetObject("buttonExposure.Image")));
            this.buttonExposure.Location = new System.Drawing.Point(12, 477);
            this.buttonExposure.Name = "buttonExposure";
            this.buttonExposure.Size = new System.Drawing.Size(100, 23);
            this.buttonExposure.TabIndex = 6;
            this.buttonExposure.UseVisualStyleBackColor = false;
            this.buttonExposure.Click += new System.EventHandler(this.buttonExposure_Click);
            // 
            // buttonCameraConnect
            // 
            this.buttonCameraConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCameraConnect.BackColor = System.Drawing.Color.Teal;
            this.buttonCameraConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonCameraConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCameraConnect.Image = global::OAGSeeker.Properties.Resources.Off;
            this.buttonCameraConnect.Location = new System.Drawing.Point(375, 14);
            this.buttonCameraConnect.Name = "buttonCameraConnect";
            this.buttonCameraConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonCameraConnect.TabIndex = 2;
            this.buttonCameraConnect.UseVisualStyleBackColor = false;
            this.buttonCameraConnect.Click += new System.EventHandler(this.buttonCameraConnect_Click);
            // 
            // textBoxRotationStep
            // 
            this.textBoxRotationStep.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxRotationStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRotationStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRotationStep.Location = new System.Drawing.Point(13, 128);
            this.textBoxRotationStep.Name = "textBoxRotationStep";
            this.textBoxRotationStep.Size = new System.Drawing.Size(100, 19);
            this.textBoxRotationStep.TabIndex = 27;
            this.textBoxRotationStep.Text = "10.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "step in °:";
            // 
            // buttonRotateZero
            // 
            this.buttonRotateZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRotateZero.BackColor = System.Drawing.Color.Teal;
            this.buttonRotateZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotateZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateZero.ForeColor = System.Drawing.Color.Silver;
            this.buttonRotateZero.Image = global::OAGSeeker.Properties.Resources.RotateZero;
            this.buttonRotateZero.Location = new System.Drawing.Point(445, 51);
            this.buttonRotateZero.Name = "buttonRotateZero";
            this.buttonRotateZero.Size = new System.Drawing.Size(100, 22);
            this.buttonRotateZero.TabIndex = 29;
            this.buttonRotateZero.UseVisualStyleBackColor = false;
            this.buttonRotateZero.Click += new System.EventHandler(this.buttonRotateZero_Click);
            // 
            // buttonRotateStep
            // 
            this.buttonRotateStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRotateStep.BackColor = System.Drawing.Color.Teal;
            this.buttonRotateStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotateStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateStep.ForeColor = System.Drawing.Color.Silver;
            this.buttonRotateStep.Image = global::OAGSeeker.Properties.Resources.Rotate;
            this.buttonRotateStep.Location = new System.Drawing.Point(12, 428);
            this.buttonRotateStep.Name = "buttonRotateStep";
            this.buttonRotateStep.Size = new System.Drawing.Size(100, 23);
            this.buttonRotateStep.TabIndex = 30;
            this.buttonRotateStep.UseVisualStyleBackColor = false;
            this.buttonRotateStep.Click += new System.EventHandler(this.buttonRotateStep_Click);
            // 
            // labelAngle
            // 
            this.labelAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAngle.AutoSize = true;
            this.labelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.Location = new System.Drawing.Point(12, 364);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(24, 20);
            this.labelAngle.TabIndex = 32;
            this.labelAngle.Text = "...";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Rotator to 0°";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Rotate one step";
            // 
            // timerPosition
            // 
            this.timerPosition.Enabled = true;
            this.timerPosition.Interval = 1000;
            this.timerPosition.Tick += new System.EventHandler(this.timerPosition_Tick);
            // 
            // timerIsRotatorMoving
            // 
            this.timerIsRotatorMoving.Enabled = true;
            this.timerIsRotatorMoving.Interval = 300;
            this.timerIsRotatorMoving.Tick += new System.EventHandler(this.timerIsRotatorMoving_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Take a picture";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(655, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.buttonRotateStep);
            this.Controls.Add(this.buttonRotateZero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRotationStep);
            this.Controls.Add(this.panelScrollArea);
            this.Controls.Add(this.labelPixelsize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRotatorConnect);
            this.Controls.Add(this.labelRotator);
            this.Controls.Add(this.buttonChooseRotator);
            this.Controls.Add(this.buttonExposure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExposure);
            this.Controls.Add(this.buttonCameraConnect);
            this.Controls.Add(this.labelCamera);
            this.Controls.Add(this.buttonChooseCamera);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "OAG Seeker";
            this.panelScrollArea.ResumeLayout(false);
            this.panelScrollArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseCamera;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.Button buttonCameraConnect;
        private System.Windows.Forms.TextBox textBoxExposure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExposure;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExposure;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button buttonRotatorConnect;
        private System.Windows.Forms.Label labelRotator;
        private System.Windows.Forms.Button buttonChooseRotator;
        private System.Windows.Forms.Label labelPixelsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelScrollArea;
        private System.Windows.Forms.TextBox textBoxRotationStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRotateZero;
        private System.Windows.Forms.Button buttonRotateStep;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerPosition;
        private System.Windows.Forms.Timer timerIsRotatorMoving;
        private System.Windows.Forms.Label label3;
    }
}

