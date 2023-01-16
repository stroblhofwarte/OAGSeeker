
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
            this.buttonFocuserConnect = new System.Windows.Forms.Button();
            this.labelFocuser = new System.Windows.Forms.Label();
            this.buttonChooseFocuser = new System.Windows.Forms.Button();
            this.buttonFineRight = new System.Windows.Forms.Button();
            this.buttonFineLeft = new System.Windows.Forms.Button();
            this.buttonFastRight = new System.Windows.Forms.Button();
            this.buttonFastLeft = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxFocuserMove = new System.Windows.Forms.TextBox();
            this.buttonFocuserMove = new System.Windows.Forms.Button();
            this.buttonFocuserStop = new System.Windows.Forms.Button();
            this.timerFocuserMoving = new System.Windows.Forms.Timer(this.components);
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
            this.textBoxRotationStep.Location = new System.Drawing.Point(84, 407);
            this.textBoxRotationStep.Name = "textBoxRotationStep";
            this.textBoxRotationStep.Size = new System.Drawing.Size(58, 19);
            this.textBoxRotationStep.TabIndex = 27;
            this.textBoxRotationStep.Text = "10.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 410);
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
            this.buttonRotateZero.Location = new System.Drawing.Point(148, 485);
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
            this.buttonRotateStep.Location = new System.Drawing.Point(148, 405);
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
            this.labelAngle.Location = new System.Drawing.Point(132, 91);
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
            this.buttonLeft.Location = new System.Drawing.Point(73, 347);
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
            this.buttonRight.Location = new System.Drawing.Point(148, 347);
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
            this.rotatorGauge.Location = new System.Drawing.Point(31, 114);
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
            this.textBoxMoveTo.Location = new System.Drawing.Point(84, 487);
            this.textBoxMoveTo.Name = "textBoxMoveTo";
            this.textBoxMoveTo.Size = new System.Drawing.Size(58, 19);
            this.textBoxMoveTo.TabIndex = 39;
            this.textBoxMoveTo.Text = "10.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Move to:";
            // 
            // buttonFocuserConnect
            // 
            this.buttonFocuserConnect.BackColor = System.Drawing.Color.Teal;
            this.buttonFocuserConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFocuserConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFocuserConnect.Image = global::OAGSeeker.Properties.Resources.Off;
            this.buttonFocuserConnect.Location = new System.Drawing.Point(248, 44);
            this.buttonFocuserConnect.Name = "buttonFocuserConnect";
            this.buttonFocuserConnect.Size = new System.Drawing.Size(40, 23);
            this.buttonFocuserConnect.TabIndex = 43;
            this.buttonFocuserConnect.UseVisualStyleBackColor = false;
            this.buttonFocuserConnect.Click += new System.EventHandler(this.buttonFocuserConnect_Click);
            // 
            // labelFocuser
            // 
            this.labelFocuser.AutoSize = true;
            this.labelFocuser.Location = new System.Drawing.Point(18, 49);
            this.labelFocuser.Name = "labelFocuser";
            this.labelFocuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFocuser.Size = new System.Drawing.Size(177, 13);
            this.labelFocuser.TabIndex = 42;
            this.labelFocuser.Text = "AAAAAAAAAAAAAAAAAAAAAAA...";
            // 
            // buttonChooseFocuser
            // 
            this.buttonChooseFocuser.BackColor = System.Drawing.Color.Teal;
            this.buttonChooseFocuser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonChooseFocuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseFocuser.Location = new System.Drawing.Point(201, 44);
            this.buttonChooseFocuser.Name = "buttonChooseFocuser";
            this.buttonChooseFocuser.Size = new System.Drawing.Size(41, 23);
            this.buttonChooseFocuser.TabIndex = 41;
            this.buttonChooseFocuser.Text = "...";
            this.buttonChooseFocuser.UseVisualStyleBackColor = false;
            this.buttonChooseFocuser.Click += new System.EventHandler(this.buttonChooseFocuser_Click);
            // 
            // buttonFineRight
            // 
            this.buttonFineRight.BackColor = System.Drawing.Color.Teal;
            this.buttonFineRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFineRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFineRight.ForeColor = System.Drawing.Color.Silver;
            this.buttonFineRight.Location = new System.Drawing.Point(406, 214);
            this.buttonFineRight.Name = "buttonFineRight";
            this.buttonFineRight.Size = new System.Drawing.Size(69, 23);
            this.buttonFineRight.TabIndex = 45;
            this.buttonFineRight.Text = ">";
            this.buttonFineRight.UseVisualStyleBackColor = false;
            this.buttonFineRight.Click += new System.EventHandler(this.buttonFineRight_Click);
            // 
            // buttonFineLeft
            // 
            this.buttonFineLeft.BackColor = System.Drawing.Color.Teal;
            this.buttonFineLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFineLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFineLeft.ForeColor = System.Drawing.Color.Silver;
            this.buttonFineLeft.Location = new System.Drawing.Point(331, 214);
            this.buttonFineLeft.Name = "buttonFineLeft";
            this.buttonFineLeft.Size = new System.Drawing.Size(69, 23);
            this.buttonFineLeft.TabIndex = 44;
            this.buttonFineLeft.Text = "<";
            this.buttonFineLeft.UseVisualStyleBackColor = false;
            this.buttonFineLeft.Click += new System.EventHandler(this.buttonFineLeft_Click);
            // 
            // buttonFastRight
            // 
            this.buttonFastRight.BackColor = System.Drawing.Color.Teal;
            this.buttonFastRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFastRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFastRight.ForeColor = System.Drawing.Color.Silver;
            this.buttonFastRight.Location = new System.Drawing.Point(406, 262);
            this.buttonFastRight.Name = "buttonFastRight";
            this.buttonFastRight.Size = new System.Drawing.Size(69, 23);
            this.buttonFastRight.TabIndex = 47;
            this.buttonFastRight.Text = ">>";
            this.buttonFastRight.UseVisualStyleBackColor = false;
            this.buttonFastRight.Click += new System.EventHandler(this.buttonFastRight_Click);
            // 
            // buttonFastLeft
            // 
            this.buttonFastLeft.BackColor = System.Drawing.Color.Teal;
            this.buttonFastLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFastLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFastLeft.ForeColor = System.Drawing.Color.Silver;
            this.buttonFastLeft.Location = new System.Drawing.Point(331, 262);
            this.buttonFastLeft.Name = "buttonFastLeft";
            this.buttonFastLeft.Size = new System.Drawing.Size(69, 23);
            this.buttonFastLeft.TabIndex = 46;
            this.buttonFastLeft.Text = "<<";
            this.buttonFastLeft.UseVisualStyleBackColor = false;
            this.buttonFastLeft.Click += new System.EventHandler(this.buttonFastLeft_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Position:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(331, 158);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 25);
            this.labelPosition.TabIndex = 49;
            this.labelPosition.Text = "<POS>";
            // 
            // textBoxFocuserMove
            // 
            this.textBoxFocuserMove.BackColor = System.Drawing.Color.CadetBlue;
            this.textBoxFocuserMove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFocuserMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFocuserMove.Location = new System.Drawing.Point(331, 351);
            this.textBoxFocuserMove.Name = "textBoxFocuserMove";
            this.textBoxFocuserMove.Size = new System.Drawing.Size(119, 19);
            this.textBoxFocuserMove.TabIndex = 50;
            this.textBoxFocuserMove.Text = "10.0";
            // 
            // buttonFocuserMove
            // 
            this.buttonFocuserMove.BackColor = System.Drawing.Color.Teal;
            this.buttonFocuserMove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFocuserMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFocuserMove.ForeColor = System.Drawing.Color.Silver;
            this.buttonFocuserMove.Location = new System.Drawing.Point(451, 349);
            this.buttonFocuserMove.Name = "buttonFocuserMove";
            this.buttonFocuserMove.Size = new System.Drawing.Size(44, 23);
            this.buttonFocuserMove.TabIndex = 51;
            this.buttonFocuserMove.Text = "go";
            this.buttonFocuserMove.UseVisualStyleBackColor = false;
            this.buttonFocuserMove.Click += new System.EventHandler(this.buttonFocuserMove_Click);
            // 
            // buttonFocuserStop
            // 
            this.buttonFocuserStop.BackColor = System.Drawing.Color.Teal;
            this.buttonFocuserStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(67)))), ((int)(((byte)(61)))));
            this.buttonFocuserStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFocuserStop.ForeColor = System.Drawing.Color.Silver;
            this.buttonFocuserStop.Location = new System.Drawing.Point(331, 407);
            this.buttonFocuserStop.Name = "buttonFocuserStop";
            this.buttonFocuserStop.Size = new System.Drawing.Size(164, 23);
            this.buttonFocuserStop.TabIndex = 52;
            this.buttonFocuserStop.Text = "X";
            this.buttonFocuserStop.UseVisualStyleBackColor = false;
            this.buttonFocuserStop.Click += new System.EventHandler(this.buttonFocuserStop_Click);
            // 
            // timerFocuserMoving
            // 
            this.timerFocuserMoving.Enabled = true;
            this.timerFocuserMoving.Interval = 300;
            this.timerFocuserMoving.Tick += new System.EventHandler(this.timerFocuserMoving_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(532, 540);
            this.Controls.Add(this.buttonFocuserStop);
            this.Controls.Add(this.buttonFocuserMove);
            this.Controls.Add(this.textBoxFocuserMove);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFastRight);
            this.Controls.Add(this.buttonFastLeft);
            this.Controls.Add(this.buttonFineRight);
            this.Controls.Add(this.buttonFineLeft);
            this.Controls.Add(this.buttonFocuserConnect);
            this.Controls.Add(this.labelFocuser);
            this.Controls.Add(this.buttonChooseFocuser);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button buttonFocuserConnect;
        private System.Windows.Forms.Label labelFocuser;
        private System.Windows.Forms.Button buttonChooseFocuser;
        private System.Windows.Forms.Button buttonFineRight;
        private System.Windows.Forms.Button buttonFineLeft;
        private System.Windows.Forms.Button buttonFastRight;
        private System.Windows.Forms.Button buttonFastLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxFocuserMove;
        private System.Windows.Forms.Button buttonFocuserMove;
        private System.Windows.Forms.Button buttonFocuserStop;
        private System.Windows.Forms.Timer timerFocuserMoving;
    }
}

