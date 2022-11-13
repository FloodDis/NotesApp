namespace NotesAppUI
{
	partial class NotesAppUIForm
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
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NoteTextRichTextBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CreationTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ModificationTimePicker = new System.Windows.Forms.DateTimePicker();
			this.NoteListBox = new System.Windows.Forms.ListBox();
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Show Category:";
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(119, 44);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(170, 24);
			this.CategoryComboBox.TabIndex = 1;
			this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// NoteTextRichTextBox
			// 
			this.NoteTextRichTextBox.Enabled = false;
			this.NoteTextRichTextBox.Location = new System.Drawing.Point(318, 133);
			this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
			this.NoteTextRichTextBox.Size = new System.Drawing.Size(470, 326);
			this.NoteTextRichTextBox.TabIndex = 3;
			this.NoteTextRichTextBox.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(315, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Created:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(544, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Modified:";
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(315, 69);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(114, 16);
			this.CategoryLabel.TabIndex = 7;
			this.CategoryLabel.Text = "Name of category";
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(15, 420);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(85, 28);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add Note";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(106, 420);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(85, 28);
			this.EditButton.TabIndex = 9;
			this.EditButton.Text = "Edit Note";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(197, 420);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(112, 28);
			this.RemoveButton.TabIndex = 10;
			this.RemoveButton.Text = "Remove Note";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.ExitToolStripMenuItem.Text = "Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.EditToolStripMenuItem.Text = "Edit";
			// 
			// AddNoteToolStripMenuItem
			// 
			this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
			this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.AddNoteToolStripMenuItem.Text = "Add Note";
			this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
			// 
			// EditNoteToolStripMenuItem
			// 
			this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
			this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.EditNoteToolStripMenuItem.Text = "Edit Note";
			this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
			// 
			// RemoveNoteToolStripMenuItem
			// 
			this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
			this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
			this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.HelpToolStripMenuItem.Text = "Help";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.AboutToolStripMenuItem.Text = "About";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// CreationTimePicker
			// 
			this.CreationTimePicker.Enabled = false;
			this.CreationTimePicker.Location = new System.Drawing.Point(379, 88);
			this.CreationTimePicker.Name = "CreationTimePicker";
			this.CreationTimePicker.Size = new System.Drawing.Size(144, 22);
			this.CreationTimePicker.TabIndex = 12;
			// 
			// ModificationTimePicker
			// 
			this.ModificationTimePicker.Enabled = false;
			this.ModificationTimePicker.Location = new System.Drawing.Point(612, 88);
			this.ModificationTimePicker.Name = "ModificationTimePicker";
			this.ModificationTimePicker.Size = new System.Drawing.Size(144, 22);
			this.ModificationTimePicker.TabIndex = 13;
			// 
			// NoteListBox
			// 
			this.NoteListBox.FormattingEnabled = true;
			this.NoteListBox.ItemHeight = 16;
			this.NoteListBox.Location = new System.Drawing.Point(15, 112);
			this.NoteListBox.Name = "NoteListBox";
			this.NoteListBox.Size = new System.Drawing.Size(294, 308);
			this.NoteListBox.TabIndex = 14;
			this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteTitleLabel.Location = new System.Drawing.Point(312, 30);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(127, 32);
			this.NoteTitleLabel.TabIndex = 15;
			this.NoteTitleLabel.Text = "Note title";
			// 
			// NotesAppUIForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 471);
			this.Controls.Add(this.NoteTitleLabel);
			this.Controls.Add(this.NoteListBox);
			this.Controls.Add(this.ModificationTimePicker);
			this.Controls.Add(this.CreationTimePicker);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NoteTextRichTextBox);
			this.Controls.Add(this.CategoryComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "NotesAppUIForm";
			this.Text = "NotesApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotesAppUIForm_FormClosing);
			this.Load += new System.EventHandler(this.NotesAppUIForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CategoryComboBox;
		private System.Windows.Forms.RichTextBox NoteTextRichTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.DateTimePicker CreationTimePicker;
		private System.Windows.Forms.DateTimePicker ModificationTimePicker;
		private System.Windows.Forms.ListBox NoteListBox;
		private System.Windows.Forms.Label NoteTitleLabel;
	}
}

