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
	[Serializable]
	public class Project
	{
		/// <summary>
		/// Список всех заметок, созданных 
		/// в приложении
		/// </summary>
		[JsonProperty]
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
		}

		/// <summary>
		/// Удалить заметку из списка
		/// </summary>
		/// <param name="index">Индекс удаляемой заметки</param>
		public void RemoveNote(int index)
		{
			_notes.RemoveAt(index);
		}

		/// <summary>
		/// Добавить заметку в список
		/// </summary>
		/// <param name="note">Добавляемая заметка</param>
		public void AddNote(Note note)
		{
			_notes.Add(note);
		}

		/// <summary>
		/// Отсортировать заметки по времени их последнего редактирования
		/// </summary>
		public void SortNotesByDate()
		{
			for (int i = 0; i < GetNoteCount(); i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (_notes[j].GetModificationTime()
					> _notes[j - 1].GetModificationTime())
					{
						Note buffer = _notes[j - 1];
						_notes[j - 1] = _notes[j];
						_notes[j] = buffer;
					}
				}
			}
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
			
			for (int i = 0; i < GetNoteCount(); i++)
			{
				if (_notes[i].GetCategory() == noteCategory)
				{
					result.AddNote(_notes[i]);
				}
			}
			return result;
		}

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public Project()
		{
			_notes = new List<Note>();
		}
	}
}
