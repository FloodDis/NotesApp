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
		/// Свойство списка заметок
		/// </summary>
		public List<Note> Notes
		{
			get { return _notes; }
		}

		/// <summary>
		/// Свойство кол-ва заметок в списке
		/// </summary>
		public int NotesCount
		{
			get { return _notes.Count(); }
		}

		/// <summary>
		/// Получить заметку по индексу
		/// </summary>
		/// <param name="index">Индекс заметки</param>
		/// <returns>Заметка с введенным индексом</returns>
		public Note this[int index]
		{
			get
			{
				return _notes[index];
			}
			set
			{
				_notes[index] = value;
				SortNotesByDate();
			}
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
			for (int i = 0; i < this.NotesCount; i++)
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
			
			//var sortedNotes = _notes.OrderBy(x => x.ModificationTime);
			//_notes = sortedNotes.ToList();
		}

		/// <summary>
		/// Получить список заметок с заданной категорией
		/// </summary>
		/// <param name="noteCategory">Категория заметки</param>
		public List<Note> GetNotesWithCategory(Category noteCategory)
		{
			if (noteCategory == Category.Default)
			{
				return _notes;
			}

			List<Note> result = new List<Note>();

			for (int i = 0; i < this.NotesCount; i++)
			{
				if (_notes[i].GetCategory() == noteCategory)
				{
					result.Add(_notes[i]);
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
