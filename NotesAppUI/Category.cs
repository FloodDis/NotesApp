using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppUI
{
	/// <summary>
	/// Перечисление категорий заметок
	/// </summary>
	enum Category
	{
		/// <summary>
		/// Все категории
		/// </summary>
		All = 1,

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
