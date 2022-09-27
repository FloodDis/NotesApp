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

namespace NotesAppUI
{
	public partial class NotesAppUIForm : Form
	{
		/// <summary>
		/// Справочная заметка.
		/// </summary>
		private Note _helpNote = new Note($"It's the title of this help note.",
			"Create your first note by clicking on the button in the lower left corner or select existed one on the left box.");

		public NotesAppUIForm()
		{
			InitializeComponent();

			if (File.Exists(ProjectManager.Path))
			{
				try
				{
					Project._notes = ProjectManager.Load();
				}
				catch
				{
					MessageBox.Show(string.Format("Failed to load notebook from {0}, check whatever file exist or maybe corrupted.", ProjectManager.Path), "Error occured.");
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
			CategoryLabel.Text = string.Format("Category: {0}", noteToShow.GetCategory());
			NoteTextRichTextBox.Text = noteToShow.GetText();
			CreationTimePicker.Value = noteToShow.GetCreationTime();
			ModificationTimePicker.Value = noteToShow.GetModificationTime();
		}

		/// <summary>
		/// Обновить содержимое списка заметок.
		/// </summary>
		private void UpdateNoteListBox()
		{
			Project._displayedNotes = Project.GetNotesWithCategory((Category)CategoryComboBox.SelectedItem);
			NoteListBox.Items.Clear();
			for (int i = 0; i < Project._displayedNotes.Count(); ++i)
			{
				NoteListBox.Items.Add(Project._displayedNotes[i].GetName());
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
			noteEditForm.Note = newNote;
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				Project._notes.Add(newNote);
				Project.SortNotes();
				ShowNote(newNote);
				UpdateNoteListBox();
			}
		}

		/// <summary>
		/// Редактировать заметки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				Note selectedNote = Project._displayedNotes[selectedNoteIndex];
				AddEditForm noteEditForm = new AddEditForm();
				noteEditForm.Note = selectedNote;
				DialogResult result = noteEditForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					ProjectManager.Save(Project._notes);
					ShowNote(selectedNote);
					UpdateNoteListBox();
				}
			}
			catch
			{
				MessageBox.Show("Please select what note need to be edited.", "Error occured.");
			}
		}

		/// <summary>
		/// Удаленить заметки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NoteListBox.SelectedIndex;
			try
			{
				//Project._displayedNotes[selectedNoteIndex].SetName("Note to delete");
				Project.SortNotes();
				Project._notes.RemoveAt(selectedNoteIndex);
				NoteListBox.SelectedIndex = -1;
				UpdateNoteListBox();
			}
			catch
			{
				MessageBox.Show("Please select what note need to be removed.", "Error occured.");
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
				Note selectedNote = Project._displayedNotes[NoteListBox.SelectedIndex];
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
			ProjectManager.Save(Project._notes);
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
