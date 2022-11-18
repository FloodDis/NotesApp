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
		private static string _defaultPath = @".\NotebookData.txt";

		/// <summary>
		/// Заданный пользователем путь для сохранения/загрузки блокнота.
		/// </summary>
		private static string _path = _defaultPath;

		/*/// <summary>
		/// Задать/получить путь сохранения/загрузки блокнота.
		/// </summary>
		public static string Path
		{
			get { return _path; }
			set { _path = value; }
		}*/

		/// <summary>
		/// Сеттер поля _path
		/// </summary>
		/// <param name="path">Путь файла, который нужно ввести</param>
		public static void SetPath(string path)
		{
			_path = path;
		}

		/// <summary>
		/// Геттер поля _path
		/// </summary>
		/// <returns>Путь файла, в котором сохраняются заметки</returns>
		public static string GetPath()
		{
			return _path;
		}

		/// <summary>
		/// Сохранить список заметок
		/// </summary>
		/// <param name="project">Список заметок для сохранения</param>
		public static void Save(Project project)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(_path))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, project);
			}
		}

		/// <summary>
		/// Загрузить список заметок
		/// </summary>
		/// <returns>Загруженный список заметок</returns>
		public static Project Load()
		{
			Project notebook = null/*JsonConvert.DeserializeObject<Project>(File.ReadAllText(_path))*/;
			JsonSerializer serializer = new JsonSerializer();
			using (StreamReader sr = new StreamReader(_path))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				notebook = (Project)serializer.Deserialize<Project>(reader);
			}

			if (notebook == null)
			{
				return new Project();
			}
			return notebook;
		}
	}
}
