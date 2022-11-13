using NotesAppClasses;

namespace NotesApp.UnitTests
{
	[TestFixture]
	public class ProjectTests
	{
		[Test(Description = "Test changing count of notes after adding")]
		public void NoteCount_ValueIncreased()
		{
			//Arrange
			var notebook = new Project();
			int expected = 2;

			//Act
			notebook.AddNote(new Note());
			notebook.AddNote(new Note());
			int actual = notebook.GetNoteCount();

			//Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description ="Test changing count of notes after removing")]
		public void NoteCount_ValueDecreased()
		{
			// Arrange
			var notebook = new Project();
			int expected = 1;

			// Act
			notebook.AddNote(new Note());
			notebook.AddNote(new Note());
			notebook.RemoveNote(1);
			int actual = notebook.GetNoteCount();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Adding note to notebook test")]
		public void AddNoteTest()
		{
			// Arrange
			var notebook = new Project();
			var expected = new Note("First note", "aaa", Category.Finances);

			// Act
			notebook.AddNote(expected);
			var actual = notebook.GetNoteByIndex(0);

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Notebook get note property test")]
		public void GetNoteTest()
		{
			// Arrange
			var notebook = new Project();
			notebook.AddNote(new Note("First note", "", Category.Default));
			notebook.AddNote(new Note("Second note", "", Category.Home));
			notebook.AddNote(new Note("Third note", "", Category.Default));
			var expected = new Note("Third note", "", Category.Default);

			// Act
			var actual = notebook.GetNoteByIndex(0);

			// Assert
			Assert.That(expected.GetName(), Is.EqualTo(actual.GetName()));
			Assert.That(expected.GetText(), Is.EqualTo(actual.GetText()));
			Assert.That(expected.GetCategory(), Is.EqualTo(actual.GetCategory()));
		}

		[Test(Description = "Get notes with certain category from notebook test")]
		public void SortNotebookTest()
		{
			// Arrange
			var notebook = new Project();
			notebook.AddNote(new Note("First note", "", Category.Default));
			notebook.AddNote(new Note("Second note", "", Category.Work));
			notebook.AddNote(new Note("Third note", "", Category.Default));
			notebook.AddNote(new Note("Fourth note", "", Category.Work));
			notebook.AddNote(new Note("Fifth note", "", Category.Documents));
			var expected1 = notebook.GetNoteByIndex(1);
			var expected2 = notebook.GetNoteByIndex(3);

			// Act
			var actual = notebook.GetNotesWithCategory(Category.Work);

			// Assert
			Assert.That(expected1, Is.EqualTo(actual.GetNoteByIndex(0)));
			Assert.That(expected2, Is.EqualTo(actual.GetNoteByIndex(1)));
		}
	}
}
