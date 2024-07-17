namespace WindowsFormsApp3
{
    partial class Form1
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerifyNumber = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnSubmitOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(332, 137);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(332, 51);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNumber.TabIndex = 1;
            
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // btnVerifyNumber
            // 
            this.btnVerifyNumber.Location = new System.Drawing.Point(438, 47);
            this.btnVerifyNumber.Name = "btnVerifyNumber";
            this.btnVerifyNumber.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyNumber.TabIndex = 5;
            this.btnVerifyNumber.Text = "Send OTP";
            this.btnVerifyNumber.UseVisualStyleBackColor = true;
            this.btnVerifyNumber.Click += new System.EventHandler(this.btnVerifyNumber_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(519, 47);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(100, 20);
            this.txtOTP.TabIndex = 6;
            
            // 
            // btnSubmitOTP
            // 
            this.btnSubmitOTP.Location = new System.Drawing.Point(625, 48);
            this.btnSubmitOTP.Name = "btnSubmitOTP";
            this.btnSubmitOTP.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitOTP.TabIndex = 7;
            this.btnSubmitOTP.Text = "Submit OTP";
            this.btnSubmitOTP.UseVisualStyleBackColor = true;
            this.btnSubmitOTP.Click += new System.EventHandler(this.btnSubmitOTP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.btnVerifyNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.btnRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerifyNumber;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnSubmitOTP;
    }
}

