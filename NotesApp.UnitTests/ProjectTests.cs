using NotesAppUI;

namespace NotesApp.UnitTests
{
	[TestFixture]
	public class ProjectTests
	{
		[Test(Description = "Test changing count of notes after adding")]
		public void NoteCount_ValueIncreased()
		{
			//Arrange
			var notebook = Project._notes;
			int expected = 2;

			//Act
			notebook.Add(new Note());
			notebook.Add(new Note());
			int actual = notebook.Count();

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description ="Test changing count of notes after removing")]
		public void NoteCount_ValueDecreased()
		{
			// Arrange
			var notebook = Project._notes;
			int expected = 1;

			// Act
			notebook.Add(new Note());
			notebook.Add(new Note());
			notebook.RemoveAt(1);
			int actual = notebook.Count();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Adding note to notebook test")]
		public void AddNoteTest()
		{
			// Arrange
			var notebook = Project._notes;
			var expected = new Note("First note", "aaa", Category.Finances);

			// Act
			notebook.Add(expected);
			var actual = notebook[0];

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Removing note from notebook test")]
		public void RemoveNoteTest()
		{
			// Arrange
			var notebook = Project._notes;

			// Act
			notebook.Add(new Note("Second note", "12ghj", Category.Home));
			notebook.RemoveAt(0);

			// Assert
			Assert.Throws<ArgumentOutOfRangeException>(() => { notebook[0].SetName("New title"); });
		}

		[Test(Description = "Notebook get note property test")]
		public void GetNoteTest()
		{
			// Arrange
			var notebook = Project._notes;
			notebook.Add(new Note("First note", "", Category.Default));
			notebook.Add(new Note("Second note", "", Category.Home));
			notebook.Add(new Note("Third note", "", Category.Default));
			var expected = new Note("Third note", "", Category.Default);

			// Act
			var actual = notebook[0];

			// Assert
			Assert.That(expected.GetName(), Is.EqualTo(actual.GetName()));
			Assert.That(expected.GetText(), Is.EqualTo(actual.GetText()));
			Assert.That(expected.GetCategory(), Is.EqualTo(actual.GetCategory()));
		}

		[Test(Description = "Get notes with certain category from notebook test")]
		public void SortNotebookTest()
		{
			// Arrange
			var notebook = Project._notes;
			notebook.Add(new Note("First note", "", Category.Default));
			notebook.Add(new Note("Second note", "", Category.Work));
			notebook.Add(new Note("Third note", "", Category.Default));
			notebook.Add(new Note("Fourth note", "", Category.Work));
			notebook.Add(new Note("Fifth note", "", Category.Documents));
			var expected1 = notebook[1];
			var expected2 = notebook[3];

			// Act
			var actual = notebook.GetNotesWithCategory(Category.Work);

			// Assert
			Assert.That(expected1, Is.EqualTo(actual[0]));
			Assert.That(expected2, Is.EqualTo(actual[1]));
		}
	}
}
