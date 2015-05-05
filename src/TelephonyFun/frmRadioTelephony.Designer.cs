namespace TelephonyFun
{
    partial class frmRadioTelephony
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtPnr = new System.Windows.Forms.TextBox();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(118, 13);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtPnr
            // 
            this.txtPnr.Location = new System.Drawing.Point(12, 15);
            this.txtPnr.Name = "txtPnr";
            this.txtPnr.Size = new System.Drawing.Size(100, 20);
            this.txtPnr.TabIndex = 1;
            this.txtPnr.Text = "TYPE YOUR PNR";
            this.txtPnr.Enter += new System.EventHandler(this.txtPnr_Enter);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(13, 62);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(375, 187);
            this.txtTranslation.TabIndex = 2;
            this.txtTranslation.Text = "Waiting for input";
            // 
            // btnSpeech
            // 
            this.btnSpeech.Location = new System.Drawing.Point(313, 13);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(75, 23);
            this.btnSpeech.TabIndex = 0;
            this.btnSpeech.Text = "Speech";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(240, 13);
            this.numSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(62, 20);
            this.numSpeed.TabIndex = 3;
            this.numSpeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // numVolume
            // 
            this.numVolume.Location = new System.Drawing.Point(240, 39);
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(62, 20);
            this.numVolume.TabIndex = 5;
            this.numVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frmRadioTelephony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.txtPnr);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.btnTranslate);
            this.Name = "frmRadioTelephony";
            this.Text = "Radio Telephony";
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtPnr;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVolume;
    }
}

