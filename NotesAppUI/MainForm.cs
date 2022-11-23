using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesAppClasses;

namespace NotesAppUI
{
	public partial class NotesAppUIForm : Form
	{
		/// <summary>
		/// Список заметок
		/// </summary>
		private Project _notesList;

		/// <summary>
		/// Список заметок для отображения на экране
		/// </summary>
		private Project _displayedNotes;

		public NotesAppUIForm()
		{
			InitializeComponent();

			_notesList = new Project();
			_displayedNotes = _notesList;

			if (File.Exists(ProjectManager.GetPath()))
			{
				try
				{
					_notesList = ProjectManager.Load();
				}
				catch
				{
					MessageBox.Show("Can't load list of saved notes from path", "Error");
				}
			}
		}

		private void NotesAppUIForm_Load(object sender, EventArgs e)
		{
			foreach (Category noteType in Enum.GetValues(typeof(Category)))
			{
				CategoryComboBox.Items.Add(noteType);
			}
			CategoryComboBox.SelectedItem = Category.Default;
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm form = new AboutForm();
			form.ShowDialog();
		}

		/// <summary>
		/// Отобразить содержимое заметки
		/// </summary>
		/// <param name="noteToShow">Заметка для отображения</param>
		private void ShowNote(Note noteToShow)
		{
			NoteTitleLabel.Text = noteToShow.GetName();
			CategoryLabel.Text = "Category: " + noteToShow.GetCategory().ToString();
			NoteTextRichTextBox.Text = noteToShow.GetText();
			CreationTimePicker.Value = noteToShow.GetCreationTime();
			ModificationTimePicker.Value = noteToShow.GetModificationTime();
		}

		/// <summary>
		/// Обновить содержимое списка заметок.
		/// </summary>
		private void UpdateNoteListBox()
		{
			_displayedNotes = _notesList.GetNotesWithCategory((Category)CategoryComboBox.SelectedItem);
			NoteListBox.Items.Clear();
			for (int i = 0; i < _displayedNotes.GetNoteCount(); ++i)
			{
				NoteListBox.Items.Add(_displayedNotes.GetNoteByIndex(i).GetName());
			}
		}

		/// <summary>
		/// Создать новую заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			Note newNote = new Note();
			AddEditForm noteEditForm = new AddEditForm();
			noteEditForm.SetNote(newNote);
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_notesList.AddNote(newNote);
				_notesList.SortNotesByDate();
				ShowNote(newNote);
				UpdateNoteListBox();
			}
		}

		/// <summary>
		/// Отредактировать заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				Note selectedNote = _displayedNotes.GetNoteByIndex(selectedNoteIndex);
				AddEditForm noteEditForm = new AddEditForm();
				noteEditForm.SetNote(selectedNote);
				DialogResult result = noteEditForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					ProjectManager.Save(_notesList);
					ShowNote(selectedNote);
					_notesList.SortNotesByDate();
					UpdateNoteListBox();
				}
			}
			catch
			{
				MessageBox.Show("Select note that needs editing", "Error");
			}
		}

		/// <summary>
		/// Удалить заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				_notesList.SortNotesByDate();
				_notesList.RemoveNote(selectedNoteIndex);
				NoteListBox.SelectedIndex = -1;
				UpdateNoteListBox();
			}
			catch
			{
				MessageBox.Show("Select note for removal", "Error");
			}
		}

		/// <summary>
		/// Отсортировать заметки по заданной категории
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateNoteListBox();
		}

		private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NoteListBox.SelectedIndex != -1)
			{
				Note selectedNote = _displayedNotes.GetNoteByIndex(NoteListBox.SelectedIndex);
				ShowNote(selectedNote);
			}
			else
			{
				NoteTitleLabel.Text = "";
				CategoryLabel.Text = "Category:";
				NoteTextRichTextBox.Text = "";
				CreationTimePicker.Value = DateTime.Now;
				ModificationTimePicker.Value = DateTime.Now;
			}
		}

		private void NotesAppUIForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectManager.Save(_notesList);
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddButton_Click(sender, e);
		}

		private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditButton_Click(sender, e);
		}

		private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RemoveButton_Click(sender, e);
		}
	}
}
