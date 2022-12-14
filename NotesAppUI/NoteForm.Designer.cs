namespace NotesAppUI
{
	partial class NoteForm
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
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ModificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.NoteRichTextBox = new System.Windows.Forms.RichTextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Location = new System.Drawing.Point(84, 16);
			this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(513, 27);
			this.TitleTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Category:";
			// 
			// AddCategoryComboBox
			// 
			this.AddCategoryComboBox.FormattingEnabled = true;
			this.AddCategoryComboBox.Location = new System.Drawing.Point(85, 66);
			this.AddCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AddCategoryComboBox.Name = "AddCategoryComboBox";
			this.AddCategoryComboBox.Size = new System.Drawing.Size(121, 28);
			this.AddCategoryComboBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(241, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Modified:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Created:";
			// 
			// CreationDateTimePicker
			// 
			this.CreationDateTimePicker.Enabled = false;
			this.CreationDateTimePicker.Location = new System.Drawing.Point(84, 118);
			this.CreationDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CreationDateTimePicker.Name = "CreationDateTimePicker";
			this.CreationDateTimePicker.Size = new System.Drawing.Size(134, 27);
			this.CreationDateTimePicker.TabIndex = 8;
			// 
			// ModificationDateTimePicker
			// 
			this.ModificationDateTimePicker.Enabled = false;
			this.ModificationDateTimePicker.Location = new System.Drawing.Point(309, 118);
			this.ModificationDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ModificationDateTimePicker.Name = "ModificationDateTimePicker";
			this.ModificationDateTimePicker.Size = new System.Drawing.Size(134, 27);
			this.ModificationDateTimePicker.TabIndex = 9;
			// 
			// NoteRichTextBox
			// 
			this.NoteRichTextBox.Location = new System.Drawing.Point(16, 171);
			this.NoteRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NoteRichTextBox.Name = "NoteRichTextBox";
			this.NoteRichTextBox.Size = new System.Drawing.Size(583, 443);
			this.NoteRichTextBox.TabIndex = 10;
			this.NoteRichTextBox.Text = "";
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(514, 622);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(85, 35);
			this.CancelButton.TabIndex = 11;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(423, 622);
			this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(85, 35);
			this.OKButton.TabIndex = 12;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 669);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.NoteRichTextBox);
			this.Controls.Add(this.ModificationDateTimePicker);
			this.Controls.Add(this.CreationDateTimePicker);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddCategoryComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "NoteForm";
			this.ShowIcon = false;
			this.Text = "Add/Edit Note";
			this.Load += new System.EventHandler(this.NoteForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox AddCategoryComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker CreationDateTimePicker;
		private System.Windows.Forms.DateTimePicker ModificationDateTimePicker;
		private System.Windows.Forms.RichTextBox NoteRichTextBox;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OKButton;
	}
}