using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace NotesAppClasses
{
	/// <summary>
	/// Менеджер проекта
	/// </summary>
	static public class ProjectManager
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
		public static void Save(Project project)
		{
			File.WriteAllText(_path, JsonConvert.SerializeObject(project, Formatting.Indented));
		}

		/// <summary>
		/// Загрузить список заметок
		/// </summary>
		/// <returns>Загруженный список заметок</returns>
		public static Project Load()
		{
			Project notebook = JsonConvert.DeserializeObject<Project>(File.ReadAllText(_path));
			if (notebook == null)
			{
				return new Project();
			}
			return notebook;
		}
	}
}
