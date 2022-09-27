using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppUI
{
	/// <summary>
	/// Проект
	/// </summary>
	static internal class Project
	{
		/// <summary>
		/// Список всех заметок, созданных 
		/// в приложении
		/// </summary>
		static public List<Note> _notes = new List<Note>();

		/// <summary>
		/// Список заметок для отображения на экране
		/// </summary>
		static public List<Note> _displayedNotes = _notes;

		/// <summary>
		/// Получить заметку по её индексу в массиве.
		/// </summary>
		/// <param name="index">Индекс заметки.</param>
		/// <returns>Заметка по заданному индексу.</returns>
		static public Note GetNoteByIndex(int index)
		{
			return _notes[index];
		}

		/// <summary>
		/// Добавить заметку по индексу
		/// </summary>
		/// <param name="index">Индекс добавляемой заметки</param>
		/// <param name="note">Заметка</param>
		static public void SetNoteByIndex(int index, Note note)
		{
			_notes[index] = note;
			SortNotes();
		}

		/// <summary>
		/// Удалить заметку из списка
		/// </summary>
		/// <param name="index">Индекс удаляемой заметки</param>
		static public void RemoveNote(int index)
		{
			_notes.RemoveAt(index);
			SortNotes();
		}

		/// <summary>
		/// Отсортировать заметки по времени их последнего редактирования
		/// </summary>
		static public void SortNotes()
		{
			_notes.Sort((t1, t2) => DateTime.Compare(t2.GetCreationTime(), t1.GetModificationTime()));
		}

		/// <summary>
		/// Получить список заметок с заданной категорией.
		/// </summary>
		/// <param name="noteCategory">Категория заметки.</param>
		public static List<Note> GetNotesWithCategory(Category noteCategory)
		{
			if (noteCategory == Category.Default)
			{
				return _notes;
			}

			List<Note> result = new List<Note>();
			foreach (Note note in _notes)
			{
				if (note.GetCategory() == noteCategory)
				{
					result.Add(note);
				}
			}
			return result;
		}
	}
}
