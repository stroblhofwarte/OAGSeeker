
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
            this.backgroundWorkerExposure = new System.ComponentModel.BackgroundWorker();
            this.labelRotator = new System.Windows.Forms.Label();
            this.buttonChooseRotator = new System.Windows.Forms.Button();
            this.buttonRotatorConnect = new System.Windows.Forms.Button();
            this.textBoxRotationStep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRotateZero = new System.Windows.Forms.Button();
            this.buttonRotateStep = new System.Windows.Forms.Button();
            this.labelAngle = new System.Windows.Forms.Label();
            this.timerPosition = new System.Windows.Forms.Timer(this.components);
            this.timerIsRotatorMoving = new System.Windows.Forms.Timer(this.components);
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.rotatorGauge = new AquaControls.AquaGauge();
            this.textBoxMoveTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRotator
            // 
            this.labelRotator.AutoSize = true;
            this.labelRotator.Location = new System.Drawing.Point(18, 20);
            this.labelRotator.Name = "labelRotator";
            this.labelRotator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRotator.Size = new System.Drawing.Size(177, 13);
            this.labelRotator.TabIndex = 10;
            this.labelRotator.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // buttonChooseRotator
            // 
            this.buttonChooseRotator.BackColor = System.Drawing.Color.Teal;
            this.buttonChooseRotator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseRotator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseRotator.Location = new System.Drawing.Point(201, 15);
            this.buttonChooseRotator.Name = "buttonChooseRotator";
            this.buttonChooseRotator.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseRotator.TabIndex = 9;
            this.buttonChooseRotator.Text = "...";
            this.buttonChooseRotator.UseVisualStyleBackColor = false;
            this.buttonChooseRotator.Click += new System.EventHandler(this.buttonChooseRotator_Click);
            // 
            // buttonRotatorConnect
            // 
            this.buttonRotatorConnect.BackColor = System.Drawing.Color.Teal;
            this.buttonRotatorConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotatorConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotatorConnect.Image = global::OAGSeeker.Properties.Resources.Off;
            this.buttonRotatorConnect.Location = new System.Drawing.Point(248, 15);
            this.buttonRotatorConnect.Name = "buttonRotatorConnect";
            this.buttonRotatorConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonRotatorConnect.TabIndex = 11;
            this.buttonRotatorConnect.UseVisualStyleBackColor = false;
            this.buttonRotatorConnect.Click += new System.EventHandler(this.buttonRotatorConnect_Click);
            // 
            // textBoxRotationStep
            // 
            this.textBoxRotationStep.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxRotationStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRotationStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRotationStep.Location = new System.Drawing.Point(83, 362);
            this.textBoxRotationStep.Name = "textBoxRotationStep";
            this.textBoxRotationStep.Size = new System.Drawing.Size(58, 19);
            this.textBoxRotationStep.TabIndex = 27;
            this.textBoxRotationStep.Text = "10.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "step in °";
            // 
            // buttonRotateZero
            // 
            this.buttonRotateZero.BackColor = System.Drawing.Color.Teal;
            this.buttonRotateZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotateZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateZero.ForeColor = System.Drawing.Color.Silver;
            this.buttonRotateZero.Image = global::OAGSeeker.Properties.Resources.RotateZero;
            this.buttonRotateZero.Location = new System.Drawing.Point(147, 440);
            this.buttonRotateZero.Name = "buttonRotateZero";
            this.buttonRotateZero.Size = new System.Drawing.Size(69, 22);
            this.buttonRotateZero.TabIndex = 29;
            this.buttonRotateZero.UseVisualStyleBackColor = false;
            this.buttonRotateZero.Click += new System.EventHandler(this.buttonRotateZero_Click);
            // 
            // buttonRotateStep
            // 
            this.buttonRotateStep.BackColor = System.Drawing.Color.Teal;
            this.buttonRotateStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRotateStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateStep.ForeColor = System.Drawing.Color.Silver;
            this.buttonRotateStep.Image = global::OAGSeeker.Properties.Resources.Rotate;
            this.buttonRotateStep.Location = new System.Drawing.Point(147, 360);
            this.buttonRotateStep.Name = "buttonRotateStep";
            this.buttonRotateStep.Size = new System.Drawing.Size(69, 23);
            this.buttonRotateStep.TabIndex = 30;
            this.buttonRotateStep.UseVisualStyleBackColor = false;
            this.buttonRotateStep.Click += new System.EventHandler(this.buttonRotateStep_Click);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.Location = new System.Drawing.Point(131, 46);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(24, 20);
            this.labelAngle.TabIndex = 32;
            this.labelAngle.Text = "...";
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
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Teal;
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.ForeColor = System.Drawing.Color.Silver;
            this.buttonLeft.Location = new System.Drawing.Point(72, 302);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(69, 23);
            this.buttonLeft.TabIndex = 36;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.Teal;
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.ForeColor = System.Drawing.Color.Silver;
            this.buttonRight.Location = new System.Drawing.Point(147, 302);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(69, 23);
            this.buttonRight.TabIndex = 37;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // rotatorGauge
            // 
            this.rotatorGauge.BackColor = System.Drawing.Color.Transparent;
            this.rotatorGauge.DialColor = System.Drawing.Color.Lavender;
            this.rotatorGauge.DialText = null;
            this.rotatorGauge.Glossiness = 11.36364F;
            this.rotatorGauge.Location = new System.Drawing.Point(30, 69);
            this.rotatorGauge.MaxValue = 0F;
            this.rotatorGauge.MinValue = 0F;
            this.rotatorGauge.Name = "rotatorGauge";
            this.rotatorGauge.NoOfDivisions = 12;
            this.rotatorGauge.NoOfSubDivisions = 2;
            this.rotatorGauge.RecommendedValue = 0F;
            this.rotatorGauge.Size = new System.Drawing.Size(227, 227);
            this.rotatorGauge.TabIndex = 38;
            this.rotatorGauge.ThresholdPercent = 0F;
            this.rotatorGauge.Value = 0F;
            // 
            // textBoxMoveTo
            // 
            this.textBoxMoveTo.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxMoveTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoveTo.Location = new System.Drawing.Point(83, 442);
            this.textBoxMoveTo.Name = "textBoxMoveTo";
            this.textBoxMoveTo.Size = new System.Drawing.Size(58, 19);
            this.textBoxMoveTo.TabIndex = 39;
            this.textBoxMoveTo.Text = "10.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Move to:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(300, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMoveTo);
            this.Controls.Add(this.rotatorGauge);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.buttonRotateStep);
            this.Controls.Add(this.buttonRotateZero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRotationStep);
            this.Controls.Add(this.buttonRotatorConnect);
            this.Controls.Add(this.labelRotator);
            this.Controls.Add(this.buttonChooseRotator);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "OAG Seeker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerExposure;
        private System.Windows.Forms.Button buttonRotatorConnect;
        private System.Windows.Forms.Label labelRotator;
        private System.Windows.Forms.Button buttonChooseRotator;
        private System.Windows.Forms.TextBox textBoxRotationStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRotateZero;
        private System.Windows.Forms.Button buttonRotateStep;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Timer timerPosition;
        private System.Windows.Forms.Timer timerIsRotatorMoving;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private AquaControls.AquaGauge rotatorGauge;
        private System.Windows.Forms.TextBox textBoxMoveTo;
        private System.Windows.Forms.Label label1;
    }
}

