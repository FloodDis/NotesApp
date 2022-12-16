namespace NotesAppUI
{
	partial class AboutForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.EmailLinkLabel = new System.Windows.Forms.Label();
			this.MailboxLinkLabel = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "NoteApp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(15, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "v. 1.0.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(15, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Author: Vladislav Sechenov";
			// 
			// EmailLinkLabel
			// 
			this.EmailLinkLabel.AutoSize = true;
			this.EmailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EmailLinkLabel.Location = new System.Drawing.Point(15, 188);
			this.EmailLinkLabel.Name = "EmailLinkLabel";
			this.EmailLinkLabel.Size = new System.Drawing.Size(138, 18);
			this.EmailLinkLabel.TabIndex = 3;
			this.EmailLinkLabel.Text = "e-mail for feedback:";
			// 
			// MailboxLinkLabel
			// 
			this.MailboxLinkLabel.AutoSize = true;
			this.MailboxLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.MailboxLinkLabel.Location = new System.Drawing.Point(170, 188);
			this.MailboxLinkLabel.Name = "MailboxLinkLabel";
			this.MailboxLinkLabel.Size = new System.Drawing.Size(161, 18);
			this.MailboxLinkLabel.TabIndex = 4;
			this.MailboxLinkLabel.TabStop = true;
			this.MailboxLinkLabel.Text = "vlad.sechenov@mail.ru";
			this.MailboxLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailboxLinkLabel_LinkClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(15, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "GitGub:";
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GitHubLinkLabel.Location = new System.Drawing.Point(73, 232);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(137, 18);
			this.GitHubLinkLabel.TabIndex = 6;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "FloodDis/NotesApp";
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 342);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(188, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "2022 Vladislav Sechenov ©";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 378);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.MailboxLinkLabel);
			this.Controls.Add(this.EmailLinkLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label EmailLinkLabel;
		private System.Windows.Forms.LinkLabel MailboxLinkLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel GitHubLinkLabel;
		private System.Windows.Forms.Label label6;
	}
}