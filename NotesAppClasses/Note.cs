using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NotesAppClasses
{
	/// <summary>
	/// Заметка
	/// </summary>
	public class Note
	{
		/// <summary>
		/// Стандартный заголовок заметки
		/// </summary>
		private const string _defaultNoteTitle = "Untitled Note";

		/// <summary>
		/// Содержимое заметки по умолчанию
		/// </summary>
		private const string _defaultNoteText = "Write your note here.";

		/// <summary>
		/// Стандартная категория заметки
		/// </summary>
		private const Category _defaultNoteCategory = Category.Default;

		/// <summary>
		/// Название заметки
		/// </summary>
		[JsonProperty]
		private string _name;

		/// <summary>
		/// Категория заметки
		/// </summary>
		[JsonProperty]
		private Category _category;

		/// <summary>
		/// Текст заметки
		/// </summary>
		[JsonProperty]
		private string _text;

		/// <summary>
		/// Время создания заметки
		/// </summary>
		[JsonProperty]
		private DateTime _creationTime = DateTime.Now;

		/// <summary>
		/// Время изменения заметки
		/// </summary>
		[JsonProperty]
		private DateTime _modificationTime = DateTime.Now;

		/// <summary>
		/// Сеттер поля _name
		/// </summary>
		/// <param name="name">Название заметки</param>
		public void SetName(string name)
		{
			if (name == "")
			{
				_name = "Без названия";
			}
			else
			{
				_name = name;
			}
			_modificationTime = DateTime.Now;
		}

		/// <summary>
		/// Сеттер поля _category
		/// </summary>
		/// <param name="category">Категория заметки</param>
		public void SetCategory(Category category)
		{
			_category = category;
			_modificationTime = DateTime.Now;
		}

		/// <summary>
		/// Сеттер поля _text
		/// </summary>
		/// <param name="text">Текст заметки</param>
		public void SetText(string text)
		{
			_text = text;
			_modificationTime = DateTime.Now;
		}

		/// <summary>
		/// Сеттер поля _creationTime
		/// </summary>
		/// <param name="creationTime">Время создания заметки</param>
		public void SetCreationTime(DateTime creationTime)
		{
			_creationTime = creationTime;
		}

		/// <summary>
		/// Сеттер поля _modoficationTime
		/// </summary>
		/// <param name="modificationTime">Время последнего редактирования заметки</param>
		public void SetModificationTime(DateTime modificationTime)
		{
			_modificationTime = modificationTime;
		}

		/// <summary>
		/// Геттер поля _name
		/// </summary>
		/// <returns>Название заметки</returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Геттер поля _category
		/// </summary>
		/// <returns>Категория заметки</returns>
		public Category GetCategory()
		{
			return _category;
		}

		/// <summary>
		/// Геттер поля _text
		/// </summary>
		/// <returns>Текст заметки</returns>
		public string GetText()
		{
			return _text;
		}

		/// <summary>
		/// Геттер поля _creationTime
		/// </summary>
		/// <returns>Время создания заметки</returns>
		public DateTime GetCreationTime()
		{
			return _creationTime;
		}

		/// <summary>
		/// Геттер поля _modificationTime
		/// </summary>
		/// <returns>Время последнего редактирования заметки</returns>
		public DateTime GetModificationTime()
		{
			return _modificationTime;
		}

		/// <summary>
		/// Создание заметки по заданному заголовку, содержимому и её категории
		/// </summary>
		/// <param name="title">Заголовок заметки</param>
		/// <param name="text">Содержимое заметки</param>
		/// <param name="noteCategory">Категория заметки</param>
		public Note(string title = _defaultNoteTitle, string text = _defaultNoteText, Category noteCategory = _defaultNoteCategory)
		{
			_name = title;
			_text = text;
			_category = noteCategory;
		}
	}
}
