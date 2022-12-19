using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.UnitTests;

[TestFixture]
public class ProjectManagerTest
{
	[Test(Description = "Тест сохранения и загрузки списка заметок")]
	public void TestSaveLoad()
	{
		var expected = new Project();

		expected.AddNote(new Note("First note", "Text", Category.Documents));
		expected.AddNote(new Note("Second note", "Text", Category.People));
		ProjectManager.Path = @".\NotesApp.txt";
		ProjectManager.Save(expected);
		var actual = ProjectManager.Load();


		Assert.AreEqual(expected.ToString(), actual.ToString());

		if (File.Exists(ProjectManager.Path))
		{
			File.Delete(ProjectManager.Path);
		}
	}

	[Test(Description = "Тест свойства поля _path")]
	public void TestGetSetPath()
	{
		var expected = @"..\Notes.txt";

		ProjectManager.Path = expected;
		var actual = ProjectManager.Path;

		Assert.AreEqual(expected, actual);
	}
}
