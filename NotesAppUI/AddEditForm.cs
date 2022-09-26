using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesAppUI
{
	public partial class AddEditForm : Form
	{
		private Note _noteToEdit;
		public bool _isAddButton;
		public AddEditForm(bool isAddButton)
		{
			InitializeComponent();
			_isAddButton = isAddButton;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if (TitleTextBox.Text.Length > 15)
			{
				MessageBox.Show("The note title must be less than 15 characters.", "Error occured.");
				return;
			}
			_noteToEdit.SetCategory((Category)AddCategoryComboBox.SelectedItem);
			_noteToEdit.SetName(TitleTextBox.Text);
			_noteToEdit.SetText(NoteTextBox.Text);
			_noteToEdit.SetModificationTime(DateTime.Now);
			Project._notes.Add(_noteToEdit);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void AddEditForm_Load(object sender, EventArgs e)
		{
			AddCategoryComboBox.Items.Add(Category.Documents);
			AddCategoryComboBox.Items.Add(Category.Finances);
			AddCategoryComboBox.Items.Add(Category.HealthAndSport);
			AddCategoryComboBox.Items.Add(Category.Home);
			AddCategoryComboBox.Items.Add(Category.People);
			AddCategoryComboBox.Items.Add(Category.Work);
			AddCategoryComboBox.Items.Add(Category.Other);
		}
	}
}
