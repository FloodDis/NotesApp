using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppClasses
{
	/// <summary>
	/// Проект
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Список всех заметок, созданных 
		/// в приложении
		/// </summary>
		private List<Note> _notes;

		/// <summary>
		/// Получить текущее кол-во заметок
		/// </summary>
		/// <returns>Текущее кол-во заметок</returns>
		public int GetNoteCount()
		{
			return _notes.Count;
		}

		/// <summary>
		/// Получить заметку по её индексу в массиве.
		/// </summary>
		/// <param name="index">Индекс заметки</param>
		/// <returns>Заметка по заданному индексу</returns>
		public Note GetNoteByIndex(int index)
		{
			return _notes[index];
		}

		/// <summary>
		/// Добавить заметку по индексу
		/// </summary>
		/// <param name="index">Индекс добавляемой заметки</param>
		/// <param name="note">Заметка</param>
		public void SetNoteByIndex(int index, Note note)
		{
			_notes[index] = note;
			SortNotes();
		}

		/// <summary>
		/// Удалить заметку из списка
		/// </summary>
		/// <param name="index">Индекс удаляемой заметки</param>
		public void RemoveNote(int index)
		{
			_notes.RemoveAt(index);
			SortNotes();
		}

		/// <summary>
		/// Добавить заметку в список
		/// </summary>
		/// <param name="note">Добавляемая заметка</param>
		public void AddNote(Note note)
		{
			_notes.Add(note);
			SortNotes();
		}

		/// <summary>
		/// Отсортировать заметки по времени их последнего редактирования
		/// </summary>
		public void SortNotes()
		{
			_notes.Sort((t1, t2) => DateTime.Compare(t2.GetCreationTime(), t1.GetModificationTime()));
		}

		/// <summary>
		/// Получить список заметок с заданной категорией
		/// </summary>
		/// <param name="noteCategory">Категория заметки</param>
		public Project GetNotesWithCategory(Category noteCategory)
		{
			if (noteCategory == Category.Default)
			{
				return this;
			}

			Project result = new Project();
			foreach (Note note in _notes)
			{
				if (note.GetCategory() == noteCategory)
				{
					result.AddNote(note);
				}
			}
			return result;
		}

		/// <summary>
		/// Конструктор без параметров
		/// </summary>
		public Project()
		{
			_notes = new List<Note>();
		}
	}
}
