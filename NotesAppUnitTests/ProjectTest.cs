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
	internal class ProjectTest
	{
		[Test(Description = "Тест геттера кол-ва заметок в списке")]
		public void TestNotesCountsGet()
		{
			var expected = 0;

			var project = new Project();
			var actual = project.GetNoteCount();

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест функций добавления заметки в конец списка и получения заметки по индексу")]
		public void TestNotesGetByIndexSetInTheEnd()
		{
			var expected = new Note("Note name", "Note text", Category.Finances);

			var project = new Project();
			project.AddNote(expected);
			var actual = project.GetNoteByIndex(0);

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест функции добавления элемента по индексу в список и получения заметки по индексу")]
		public void TestNotesSetGetByIndex()
		{
			var expected = new Note("Edited note", "Note text", Category.Finances);

			var project = new Project();
			project.AddNote(new Note("Note", "Text", Category.Home));
			project.AddNote(new Note("Note", "Text", Category.Home));
			project.AddNote(new Note("Note", "Text", Category.Home));
			project.SetNoteByIndex(1, expected);
			var actual = project.GetNoteByIndex(1);

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест функции удаления заметки")]
		public void TestRemoveNote()
		{
			var expected = new Note("Third note", "Text", Category.Finances);

			var project = new Project();
			project.AddNote(new Note("First note", "Text", Category.People));
			project.AddNote(new Note("Second note", "Text", Category.People));
			project.AddNote(expected);
			project.RemoveNote(1);
			var actual = project.GetNoteByIndex(1);

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест сортировки заметок по времени их последнего редактирования")]
		public void TestSortNotesByDate()
		{
			var expected = new Note("Third note", "Edited text", Category.Finances);

			var project = new Project();
			project.AddNote(new Note("First note", "Text", Category.People));
			project.AddNote(new Note("Second note", "Text", Category.People));
			project.AddNote(expected);
			project.GetNoteByIndex(2).SetText("Edited text");
			project.SortNotesByDate();
			var actual = project.GetNoteByIndex(0);

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест функции получения списка заметок категории Default")]
		public void TestGetNotesWithCategoryDefault()
		{
			var expected = new Note("First note", "Text", Category.People);

			var project = new Project();
			project.AddNote(expected);
			var actual = project.GetNotesWithCategory(Category.Default).GetNoteByIndex(0);

			Assert.AreEqual(expected, actual);
		}

		[Test(Description = "Тест функции олучения списка заметок заданной категории")]
		public void TestGetNotesWithCategory()
		{
			var expected = new Note("First note", "Text", Category.Home);

			var project = new Project();
			project.AddNote(expected);
			project.AddNote(new Note("Second note", "Text", Category.People));
			var actual = project.GetNotesWithCategory(Category.Home).GetNoteByIndex(0);

			Assert.AreEqual(expected, actual);
		}
	}
}
