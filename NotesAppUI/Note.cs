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

	}
}
