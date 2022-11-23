using NUnit.Framework;
using NotesAppClasses;
namespace NotesAppUnitTests
{
	[TestFixture]
	public class NoteTest
	{
		[Test(Description = "Тест сеттера и геттера _name в случае присвоения непустой строки")]
		public void TestNameSetGet_NotEmptyName()
		{
			var expected = "New note";

			var note = new Note();
			note.SetName(expected);
			var actual = note.GetName();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _name в случае присвоения пустой строки")]
		public void TestNameSetGet_EmptyName()
		{
			var expected = "Untitled Note";

			var note = new Note();
			note.SetName("");
			var actual = note.GetName();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _category")]
		public void TestCategorySetGet()
		{
			var expected = Category.People;

			var note = new Note();
			note.SetCategory(expected);
			var actual = note.GetCategory();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _text в случае присвоения непустой строки")]
		public void TestTextSetGet_NotEmptyText()
		{
			var expected = "Note text";

			var note = new Note();
			note.SetText(expected);
			var actual = note.GetText();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _text в случае присвоения пустой строки")]
		public void TestTextSetGet_EmptyText()
		{
			var expected = "Text of your note";

			var note = new Note();
			note.SetText("");
			var actual = note.GetText();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _creationTime")]
		public void TestCreationTimeSetGet()
		{
			var expected = DateTime.Now;

			var note = new Note();
			note.SetCreationTime(expected);
			var actual = note.GetCreationTime();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сеттера и геттера _modificationTime")]
		public void TestModificationTime()
		{
			var expected = DateTime.Now;

			var note = new Note("", "", Category.Default);
			note.SetModificationTime(expected);
			var actual = note.GetModificationTime();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест конструктора Note не по умолчанию")]
		public void TestNotDefaultNoteConstructor()
		{
			var expectedName = "New note";
			var expectedText = "Text of note";
			var expectedCategory = Category.Home;

			var note = new Note(expectedName, expectedText, expectedCategory);
			var actualName = note.GetName();
			var actualText = note.GetText();
			var actualCategory = note.GetCategory();

			Assert.AreEqual(expectedName, actualName);
			Assert.AreEqual(expectedText, actualText);
			Assert.AreEqual(expectedCategory, actualCategory);
		}

		[Test(Description = "Тест конструктора Note по умолчанию")]
		public void TestDefaultNoteConstructor() 
		{
			var expectedName = "Untitled Note";
			var expectedText = "Text of your note";
			var expectedCategory = Category.Default;

			var note = new Note();
			var actualName = note.GetName();
			var actualText = note.GetText();
			var actualCategory = note.GetCategory();

			Assert.AreEqual(expectedName, actualName);
			Assert.AreEqual(expectedText, actualText);
			Assert.AreEqual(expectedCategory, actualCategory);
		}
	}
}