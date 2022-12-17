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
using System.Linq;

namespace NotesAppUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Список заметок
		/// </summary>
		private Project _notesList;

		/// <summary>
		/// Список заметок для отображения на экране
		/// </summary>
		private List<Note> _displayedNotes;

		public MainForm()
		{
			InitializeComponent();

			_notesList = new Project();
			_displayedNotes = _notesList.Notes;

			try
			{
				_notesList = ProjectManager.Load();
			}
			catch
			{
				MessageBox.Show("Can't load list of saved notes from path", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Открыть форму со справочной информацией
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			NoteTitleLabel.Text = noteToShow.Name;
			CategoryLabel.Text = "Category: " + noteToShow.Category.ToString();
			NoteTextRichTextBox.Text = noteToShow.Text;
			CreationTimePicker.Value = noteToShow.CreationTime;
			ModificationTimePicker.Value = noteToShow.ModificationTime;
		}

		/// <summary>
		/// Обновить содержимое списка заметок, отображаемого в ListBox
		/// </summary>
		private void UpdateNoteListBox()
		{
			_displayedNotes = _notesList.GetNotesWithCategory((Category)CategoryComboBox.SelectedItem);
			NoteListBox.Items.Clear();
			for (int i = 0; i < _displayedNotes.Count; ++i)
			{
				NoteListBox.Items.Add(_displayedNotes[i].Name);
			}
		}

		/// <summary>
		/// Функция добавления заметки
		/// </summary>
		private void AddNote()
		{
			Note newNote = new Note();
			NoteForm noteEditForm = new NoteForm();
			noteEditForm.NoteToEdit = newNote;
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_notesList.AddNote(newNote);
				_notesList.SortNotesByDate();
				ShowNote(newNote);
				UpdateNoteListBox();
			}
			ProjectManager.Save(_notesList);
		}

		/// <summary>
		/// Добавить новую заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			AddNote();
		}

		/// <summary>
		/// Функция редактирования заметки
		/// </summary>
		private void EditNote()
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				Note selectedNote = _displayedNotes[selectedNoteIndex];
				NoteForm noteEditForm = new NoteForm();
				noteEditForm.NoteToEdit = selectedNote;
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
				MessageBox.Show("Select note that needs editing", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Отредактировать заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditButton_Click(object sender, EventArgs e)
		{
			EditNote();
		}

		/// <summary>
		/// Функция удаления заметки
		/// </summary>
		void RemoveNote()
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				_notesList.RemoveNote(selectedNoteIndex);
				NoteListBox.SelectedIndex = 0;
				UpdateNoteListBox();
			}
			catch
			{
				MessageBox.Show("Select note for removal", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			ProjectManager.Save(_notesList);
		}

		/// <summary>
		/// Удалить заметку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveButton_Click(object sender, EventArgs e)
		{
			RemoveNote();
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
				Note selectedNote = _displayedNotes[NoteListBox.SelectedIndex];
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

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddNote();
		}

		private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditNote();
		}

		private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RemoveNote();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			foreach (Category category in Enum.GetValues(typeof(Category))) 
			{
				CategoryComboBox.Items.Add(category);
			}
			CategoryComboBox.SelectedItem = Category.Default;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectManager.Save(_notesList);
		}
	}
}
