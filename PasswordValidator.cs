namespace PasswordValidator
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMesssage = new System.Windows.Forms.Label();
            this.btnCheckPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(50, 64);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 1;
            // 
            // lblMesssage
            // 
            this.lblMesssage.AutoSize = true;
            this.lblMesssage.Location = new System.Drawing.Point(50, 64);
            this.lblMesssage.Name = "lblMesssage";
            this.lblMesssage.Size = new System.Drawing.Size(44, 16);
            this.lblMesssage.TabIndex = 2;
            this.lblMesssage.Text = "label1";
            // 
            // btnCheckPassword
            // 
            this.btnCheckPassword.Location = new System.Drawing.Point(50, 103);
            this.btnCheckPassword.Name = "btnCheckPassword";
            this.btnCheckPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPassword.TabIndex = 3;
            this.btnCheckPassword.Text = "Провери паролата";
            this.btnCheckPassword.UseVisualStyleBackColor = true;
            this.btnCheckPassword.Click += new System.EventHandler(this.btnCheckPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckPassword);
            this.Controls.Add(this.lblMesssage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMesssage;
        private System.Windows.Forms.Button btnCheckPassword;
    }
}

