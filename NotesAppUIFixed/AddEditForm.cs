using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesAppClasses;

namespace NotesAppUIFixed
{
	public partial class AddEditForm : Form
	{
		/// <summary>
		/// Текущая редактируемая заметка
		/// </summary>
		private Note _noteToEdit;

		public void SetNote(Note note)
		{
			TitleTextBox.Text = _noteToEdit.GetName();
			NoteRichTextBox.Text = _noteToEdit.GetText();
			CreationDateTimePicker.Value = _noteToEdit.GetCreationTime();
			ModificationDateTimePicker.Value = _noteToEdit.GetModificationTime();
			AddCategoryComboBox.SelectedItem = _noteToEdit.GetCategory();
			AddCategoryComboBox.Text = _noteToEdit.GetCategory().ToString();
		}
		public AddEditForm()
		{
			InitializeComponent();

			_noteToEdit = new Note();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
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
			_noteToEdit.SetText(NoteRichTextBox.Text);
			_noteToEdit.SetModificationTime(DateTime.Now);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void AddEditForm_Load(object sender, EventArgs e)
		{
			foreach (Category noteType in Enum.GetValues(typeof(Category)))
			{
				AddCategoryComboBox.Items.Add(noteType);
			}
		}
	}
}
