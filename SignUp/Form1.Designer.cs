namespace SignUp
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSendCredentials = new System.Windows.Forms.Button();
            this.bntSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(89, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(351, 45);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(75, 23);
            this.btnNavigate.TabIndex = 1;
            this.btnNavigate.Text = "Navigate";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(215, 94);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSendCredentials
            // 
            this.btnSendCredentials.Location = new System.Drawing.Point(160, 154);
            this.btnSendCredentials.Name = "btnSendCredentials";
            this.btnSendCredentials.Size = new System.Drawing.Size(218, 23);
            this.btnSendCredentials.TabIndex = 3;
            this.btnSendCredentials.Text = "Enter Credentials";
            this.btnSendCredentials.UseVisualStyleBackColor = true;
            this.btnSendCredentials.Click += new System.EventHandler(this.btnSendCredentials_Click);
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(215, 212);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(75, 23);
            this.bntSubmit.TabIndex = 4;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 428);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.btnSendCredentials);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSendCredentials;
        private System.Windows.Forms.Button bntSubmit;
    }
}

