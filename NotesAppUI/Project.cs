using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppUI
{
	/// <summary>
	/// Проект
	/// </summary>
	internal class Project
	{
		/// <summary>
		/// Список всех заметок, созданных 
		/// в приложении
		/// </summary>
		private List<Note> _notes;

		/// <summary>
		/// Конструктор класса Project
		/// </summary>
		Project()
		{
			_notes = new List<Note>();
		}
	}
}
