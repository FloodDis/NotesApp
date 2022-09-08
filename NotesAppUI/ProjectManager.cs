using Newtonsoft.Json;
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
		/// Название файла, в котором будут храниться заметки
		/// </summary>
		static private string _fileName = "NoteApp.notes";

		/// <summary>
		/// Сохранить проект со всеми заметками в файл
		/// </summary>
		static public void SaveProject()
		{
			for(int i=0; i < Project._notes.Count; i++)
			{
				File.OpenWrite(_fileName);
				string text = JsonConvert.SerializeObject(Project._notes[i]);
				File.AppendAllText(_fileName, text + Environment.NewLine);
			}
		}

		/// <summary>
		/// Загрузить проект со всеми заметками из файла
		/// </summary>
		static public void DownloadProject()
		{
			File.OpenRead(_fileName);
			int notePosition = 0;
			foreach (var line in File.ReadLines(_fileName))
			{
				string noteInformation = line;
				Project._notes[notePosition]
					= JsonConvert.DeserializeObject<Note>(noteInformation);
				notePosition++;
			}
		}
	}
}
