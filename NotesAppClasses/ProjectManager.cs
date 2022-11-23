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
		/// Путь по умолчанию для сохранения и загрузки
		/// </summary>
		private static string _defaultPath = @".\Notes.txt";

		/// <summary>
		/// Заданный пользователем путь для сохранения и загрузки
		/// </summary>
		private static string _path = _defaultPath;

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
			if (!File.Exists(_path))
			{
				using (File.Create(_path)) 
				{
					using (StreamWriter sw = new StreamWriter(_path))
					using (JsonWriter writer = new JsonTextWriter(sw))
					{
						serializer.Serialize(writer, project);
					}
				} ;
			}
			else
			{
				using (StreamWriter sw = new StreamWriter(_path))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, project);
				}
			}
		}

		/// <summary>
		/// Загрузить список заметок
		/// </summary>
		/// <returns>Загруженный список заметок</returns>
		public static Project Load()
		{
			Project notebook = new Project();
			JsonSerializer serializer = new JsonSerializer();
			using (StreamReader sr = new StreamReader(_path))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				notebook = serializer.Deserialize<Project>(reader);
			}

			if (notebook == null)
			{
				return new Project();
			}
			return notebook;
		}
	}
}
