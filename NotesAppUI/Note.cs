using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppUI
{
	/// <summary>
	/// Заметка
	/// </summary>
	internal class Note
	{
		/// <summary>
		/// Название заметки
		/// </summary>
		private string _name;

		/// <summary>
		/// Категория заметки
		/// </summary>
		private Category _category;

		/// <summary>
		/// Текст заметки
		/// </summary>
		private string _text;

		/// <summary>
		/// Время создания заметки
		/// </summary>
		private DateTime _creationTime;

		/// <summary>
		/// Время изменения заметки
		/// </summary>
		private DateTime _modificationTime;

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
		}

		public void SetCategory(Category category)
		{
			_category = category;
		}

		public void SetText(string text)
		{
			_text = text;
		}

		public void SetCreationTime(DateTime creationTime)
		{
			_creationTime = creationTime;
		}

		public void SetModificationTime(DateTime modificationTime)
		{
			_modificationTime = modificationTime;
		}

		public string GetName()
		{
			return _name;
		}

		public Category GetCategory()
		{
			return _category;
		}

		public string GetText()
		{
			return _text;
		}

		public DateTime GetCreationTime()
		{
			return _creationTime;
		}

		public DateTime GetModificationTime()
		{
			return _modificationTime;
		}
	}
}
