using NotesAppUI;

namespace NotesApp.UnitTests
{
	[TestFixture]
	public class ProjectManagerTests
	{
		[Test(Description ="Save and load notebook tests")]
		public void SaveLoadNotebookTest()
		{
			//Arrange
			var expected = new List<Note>();

			//Act
			expected.Add(new Note("First note", "aaa", Category.Documents));
			expected.Add(new Note("Second note", "12lkjlk", Category.Finances));
			ProjectManager.Path = @"bin\Tests\NotebookData.txt";
			ProjectManager.Save(expected);
			var actual = ProjectManager.Load();

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}
	}
}