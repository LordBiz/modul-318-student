namespace ÜBER_GUI
{
    partial class MailWindow
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
            this.MailAdr = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailAdr
            // 
            this.MailAdr.Location = new System.Drawing.Point(98, 6);
            this.MailAdr.Name = "MailAdr";
            this.MailAdr.Size = new System.Drawing.Size(207, 20);
            this.MailAdr.TabIndex = 0;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(59, 32);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(246, 20);
            this.Subject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Mail Adresse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betreff:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 58);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Abbrechen";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(230, 58);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(75, 23);
            this.SendMail.TabIndex = 5;
            this.SendMail.Text = "Senden";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // MailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 92);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.MailAdr);
            this.MaximumSize = new System.Drawing.Size(325, 119);
            this.MinimumSize = new System.Drawing.Size(325, 119);
            this.Name = "MailWindow";
            this.Text = "MailWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailAdr;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SendMail;
    }
}