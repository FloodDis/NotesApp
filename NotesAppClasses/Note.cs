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
	[Serializable]
	public class Note
	{
		/// <summary>
		/// Стандартный заголовок заметки
		/// </summary>
		private const string _defaultNoteName = "Untitled Note";

		/// <summary>
		/// Содержимое заметки по умолчанию
		/// </summary>
		private const string _defaultNoteText = "Text of your note";

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
				_name = _defaultNoteName;
			}
			else
			{
				_name = name;
			}
			_modificationTime = DateTime.Now;
		}

		public string Name
		{
			get { return _name; }
			set
			{
				if (value=="")
				{
					_name = _defaultNoteName;
				}
				else
				{
					_name = value;
				}
				_modificationTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Свойство поля _category
		/// </summary>
		public Category Category 
		{ 
			get { return _category; }
			set
			{
				_category = value;
				_modificationTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Свойство поля _text
		/// </summary>
		public string Text
		{
			get { return _text; }
			set
			{
				if (value == "")
				{
					_text = _defaultNoteText;
				}
				else
				{
					_text = value;
				}
				_modificationTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Свойство поля _creationTime
		/// </summary>
		public DateTime CreationTime
		{
			get { return _creationTime; }
			set
			{
				_creationTime = value;
			}
		}

		/// <summary>
		/// Свойство поля _modificationTime
		/// </summary>
		public DateTime ModificationTime
		{
			get { return _modificationTime; }
			set
			{
				_modificationTime = value;
			}
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
			if (text == "")
			{
				_text = _defaultNoteText;
			}
			else
			{
				_text = text;
			}
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
		/// Конструктор Note
		/// </summary>
		/// <param name="name">Заголовок заметки</param>
		/// <param name="text">Содержимое заметки</param>
		/// <param name="category">Категория заметки</param>
		public Note(string name, string text, Category category)
		{
			SetName(name);
			SetText(text);
			SetCategory(category);
		}

		/// <summary>
		/// Конструктор Note по умолчанию
		/// </summary>
		public Note()
		{
			SetName(_defaultNoteName);
			SetText(_defaultNoteText);
			SetCategory(_defaultNoteCategory);
		}
	}
}
