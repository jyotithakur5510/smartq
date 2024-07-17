namespace WindowsFormsApp3
{
    partial class Loginpage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.btnVerifyOTP = new System.Windows.Forms.Button();
            this.btnSendOTP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MobileNumber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(163, 121);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(100, 20);
            this.txtOTP.TabIndex = 2;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(163, 63);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.Location = new System.Drawing.Point(163, 168);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyOTP.TabIndex = 4;
            this.btnVerifyOTP.Text = "Verify OTP";
            this.btnVerifyOTP.UseVisualStyleBackColor = true;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.Location = new System.Drawing.Point(326, 60);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(75, 23);
            this.btnSendOTP.TabIndex = 5;
            this.btnSendOTP.Text = "Send OTP";
            this.btnSendOTP.UseVisualStyleBackColor = true;
            this.btnSendOTP.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "OTP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSendOTP);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loginpage";
            this.Text = "Loginpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Button btnVerifyOTP;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Label label3;
    }
}