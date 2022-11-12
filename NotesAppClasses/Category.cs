using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppClasses
{
	/// <summary>
	/// Перечисление категорий заметок
	/// </summary>
	public enum Category
	{
		/// <summary>
		/// По умолчанию
		/// </summary>
		Default,

		/// <summary>
		/// Работа
		/// </summary>
		Work,

		/// <summary>
		/// Дом
		/// </summary>
		Home,

		/// <summary>
		/// Здоровье и спорт
		/// </summary>
		HealthAndSport,

		/// <summary>
		/// Люди
		/// </summary>
		People,

		/// <summary>
		/// Документы
		/// </summary>
		Documents,

		/// <summary>
		/// Финансы
		/// </summary>
		Finances,

		/// <summary>
		/// Другое
		/// </summary>
		Other
	}
}
