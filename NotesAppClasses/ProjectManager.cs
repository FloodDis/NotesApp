using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppClasses;

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

	public static string Path
	{
		get { return _path; }
		set { _path = value; }
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
			File.Create(_path).Close();
		}
		
		using (StreamWriter sw = new StreamWriter(_path))
		using (JsonWriter writer = new JsonTextWriter(sw))
		{
			serializer.Serialize(writer, project);
		}
		//string serializedProject=JsonConvert.SerializeObject(project, Formatting.Indented);
		//File.WriteAllText(_path, serializedProject);
	}

	/// <summary>
	/// Загрузить список заметок
	/// </summary>
	/// <returns>Загруженный список заметок</returns>
	public static Project Load()
	{
		Project project = new Project();
		JsonSerializer serializer = new JsonSerializer();
		if (!File.Exists(_path))
		{
			return new Project();
		}

		using (StreamReader sr = new StreamReader(_path))
		using (JsonReader reader = new JsonTextReader(sr))
		{
			project = serializer.Deserialize<Project>(reader);
		}

		//string fileText = File.ReadAllText(_path);
		//project = JsonConvert.DeserializeObject<Project>(fileText);

		if (project == null)
		{
			return new Project();
		}
		return project;
	}
}
