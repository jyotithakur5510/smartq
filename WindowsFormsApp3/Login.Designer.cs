namespace WindowsFormsApp3
{
    partial class Login
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
            this.btnOTP = new System.Windows.Forms.Button();
            this.btnRegisterNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MobileNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(256, 116);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(100, 20);
            this.txtOTP.TabIndex = 2;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(256, 65);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // btnVerifyOTP
            // 
            this.btnVerifyOTP.Location = new System.Drawing.Point(271, 176);
            this.btnVerifyOTP.Name = "btnVerifyOTP";
            this.btnVerifyOTP.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyOTP.TabIndex = 4;
            this.btnVerifyOTP.Text = "Verify OTP";
            this.btnVerifyOTP.UseVisualStyleBackColor = true;
            this.btnVerifyOTP.Click += new System.EventHandler(this.btnVerifyOTP_Click);
            // 
            // btnOTP
            // 
            this.btnOTP.Location = new System.Drawing.Point(389, 62);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(75, 23);
            this.btnOTP.TabIndex = 5;
            this.btnOTP.Text = "Send OTP";
            this.btnOTP.UseVisualStyleBackColor = true;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.Location = new System.Drawing.Point(410, 178);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(123, 23);
            this.btnRegisterNow.TabIndex = 7;
            this.btnRegisterNow.Text = "Register Now";
            this.btnRegisterNow.UseVisualStyleBackColor = true;
            this.btnRegisterNow.Click += new System.EventHandler(this.btnRegisterNow_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterNow);
            this.Controls.Add(this.btnOTP);
            this.Controls.Add(this.btnVerifyOTP);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Button btnVerifyOTP;
        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.Button btnRegisterNow;
    }
}