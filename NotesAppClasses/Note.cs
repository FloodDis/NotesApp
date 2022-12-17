using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NotesAppClasses;

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

	public string Name
	{
		get { return _name; }
		set
		{
			if (value == "")
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
	/// Конструктор Note
	/// </summary>
	/// <param name="name">Заголовок заметки</param>
	/// <param name="text">Содержимое заметки</param>
	/// <param name="category">Категория заметки</param>
	public Note(string name, string text, Category category)
	{
		this.Name = name;
		this.Text = text;
		this.Category = category;
	}

	/// <summary>
	/// Конструктор Note по умолчанию
	/// </summary>
	public Note()
	{
		this.Name = _defaultNoteName;
		this.Text = _defaultNoteText;
		this.Category = _defaultNoteCategory;
	}
}
