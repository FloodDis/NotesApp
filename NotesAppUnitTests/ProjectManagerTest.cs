using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NotesAppClasses;

namespace NotesApp.UnitTests
{
	[TestFixture]
	public class ProjectManagerTest
	{
		[Test(Description = "Тест сохранения и загрузки списка заметок")]
		public void TestSaveLoad()
		{
			var expected = new Project();

			expected.AddNote(new Note("First note", "Text", Category.Documents));
			expected.AddNote(new Note("Second note", "Text", Category.People));
			ProjectManager.Save(expected);
			var actual = ProjectManager.Load();


			Assert.AreEqual(expected.ToString(), actual.ToString());

			if (File.Exists(ProjectManager.GetPath()))
			{
				File.Delete(ProjectManager.GetPath());
			}
		}

		[Test(Description = "Тест геттера и сеттера _path")]
		public void TestGetSetPath()
		{
			var expected = @"..\Notes.txt";

			ProjectManager.SetPath(expected);
			var actual = ProjectManager.GetPath();

			Assert.AreEqual(expected, actual);
		}
	}
}
