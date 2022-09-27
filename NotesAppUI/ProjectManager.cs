﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace NotesAppUI
{
	/// <summary>
	/// Менеджер проекта
	/// </summary>
	static internal class ProjectManager
	{
		/// <summary>
		/// Путь по умолчанию для сохранения/загрузки блокнота.
		/// </summary>
		private static string _defaultPath = Environment.ExpandEnvironmentVariables(@"%AppData%\NotebookData.txt");

		/// <summary>
		/// Заданный пользователем путь для сохранения/загрузки блокнота.
		/// </summary>
		private static string _path = _defaultPath;

		/// <summary>
		/// Задать/получить путь сохранения/загрузки блокнота.
		/// </summary>
		public static string Path
		{
			get { return _path; }
			set { _path = value; }
		}

		/// <summary>
		/// Сохранить список заметок
		/// </summary>
		/// <param name="noteList">Список заметок для сохранения</param>
		public static void Save(List<Note> noteList)
		{
			File.WriteAllText(_path, JsonConvert.SerializeObject(noteList, Formatting.Indented));
		}

		/// <summary>
		/// Загрузить список заметок
		/// </summary>
		/// <returns>Загруженный список заметок</returns>
		public static List<Note> Load()
		{
			List<Note> notebook = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(_path));
			if (notebook == null)
			{
				return new List<Note>();
			}
			return notebook;
		}
	}
}
