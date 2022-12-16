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

namespace NotesAppUI
{
	public partial class NoteForm : Form
	{
		/// <summary>
		/// Текущая редактируемая заметка
		/// </summary>
		private Note _noteToEdit;

		public Note NoteToEdit
		{
			get { return _noteToEdit; }
			set
			{
				_noteToEdit = value;
				TitleTextBox.Text = _noteToEdit.Name;
				AddCategoryComboBox.Text = _noteToEdit.Category.ToString();
				NoteRichTextBox.Text = _noteToEdit.Text;
				CreationDateTimePicker.Value = _noteToEdit.CreationTime;
				ModificationDateTimePicker.Value = _noteToEdit.ModificationTime;
				AddCategoryComboBox.SelectedItem = _noteToEdit.Category;
			}
		}

		/// <summary>
		/// Сеттер заметки для редактирования
		/// </summary>
		/// <param name="note">Вводимая заметка</param>
		public void SetNote(Note note)
		{
			_noteToEdit = note;
			TitleTextBox.Text = _noteToEdit.Name;
			AddCategoryComboBox.Text = _noteToEdit.Category.ToString();
			NoteRichTextBox.Text = _noteToEdit.GetText();
			CreationDateTimePicker.Value = _noteToEdit.GetCreationTime();
			ModificationDateTimePicker.Value = _noteToEdit.GetModificationTime();
			AddCategoryComboBox.SelectedItem = _noteToEdit.GetCategory();
		}

		public NoteForm()
		{
			InitializeComponent();

			_noteToEdit = new Note();
		}

		/// <summary>
		/// Выход из AddEditForm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		/// <summary>
		/// Ввести введеные в форме данные в заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OKButton_Click(object sender, EventArgs e)
		{
			if (TitleTextBox.Text.Length > 15)
			{
				MessageBox.Show("The note name must be less than 15", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_noteToEdit.Category = (Category)AddCategoryComboBox.SelectedItem;
			_noteToEdit.Name = TitleTextBox.Text;
			_noteToEdit.Text = NoteRichTextBox.Text;
			_noteToEdit.ModificationTime = DateTime.Now;

			DialogResult = DialogResult.OK;
			Close();
		}

		private void NoteForm_Load(object sender, EventArgs e)
		{
			foreach (Category category in Enum.GetValues(typeof(Category)))
			{
				AddCategoryComboBox.Items.Add(category);
			}
			AddCategoryComboBox.SelectedItem = Category.Default;
		}
	}
}
