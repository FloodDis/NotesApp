﻿using NotesAppUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.UnitTests
{
	[TestFixture]
	internal class NoteTests
	{
		[Test(Description = "Note title default value test")]
		public void DefaultTitle_CorrectValue()
		{
			// Arrange
			var note = new Note();
			var expected = "Untitled Note";

			// Act
			var actual = note.GetName();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note text default value test")]
		public void DefaultText_CorrectValue()
		{
			// Arrange
			var note = new Note();
			var expected = "Write your note here.";

			// Act
			var actual = note.GetText();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note category default value test")]
		public void DefaultCategory_CorrectValue()
		{
			// Arrange
			var note = new Note();
			var expected = Category.Default;

			// Act
			var actual = note.GetCategory();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note title getter/setter test")]
		public void Title_CorrectValue()
		{
			// TODO: + оформить все юнит-тесты в виде трёх блоков как сделано ниже: Подготовка данных Arrange, вызов тестируемой функциональности Act, и проверка правильности результата Assert
			// Arrange
			var note = new Note();
			var expected = "First Note";

			// Act
			note.SetName("First Note");
			var actual = note.GetName();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note text getter/setter test")]
		public void Text_CorrectValue()
		{
			// Arrange
			var note = new Note();
			var expected = "Write you note here";

			// Act
			note.SetText("Write you note here");
			var actual = note.GetText();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note category getter/setter test")]
		public void Category_CorrectValue()
		{
			// Arrange
			var note = new Note();
			var expected = Category.Documents;

			// Act
			note.SetCategory(Category.Documents);
			var actual = note.GetCategory();

			// Assert
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test(Description = "Note constructor value test")]
		public void NoteConstructor_CorrectValue()
		{
			// Arrange
			var note = new Note("Note title", "Note text", Category.HealthAndSport);
			var expectedTitle = "Note title";
			var expectedText = "Note text";
			var expectedCategory = Category.HealthAndSport;

			// Act
			var actualTitle = note.GetName();
			var actualText = note.GetText();
			var actualCategory = note.GetCategory();

			// Assert
			Assert.That(expectedTitle, Is.EqualTo(actualTitle));
			Assert.That(expectedText, Is.EqualTo(actualText));
			Assert.That(expectedCategory, Is.EqualTo(actualCategory));
		}

		[Test(Description = "Test of Note time modification change after editing title")]
		public void TitleChangeTime_ValueChanged()
		{
			// Arrange
			var note = new Note();
			var expected = note.GetModificationTime();

			// Act
			note.SetName("New note title...");
			var actual = note.GetModificationTime();

			// Assert
			Assert.That(expected, Is.LessThan(actual));
		}

		[Test(Description = "Test of Note time modification change after editing text")]
		public void TextChangeTime_ValueChanged()
		{
			// Arrange
			var note = new Note();
			var expected = note.GetModificationTime();

			// Act
			note.SetText("New note text...");
			var actual = note.GetModificationTime();

			// Assert
			Assert.That(expected, Is.LessThan(actual));
		}

		[Test(Description = "Test of Note time modification change after editing category")]
		public void CategoryChangeTime_ValueChanged()
		{
			// Arrange
			var note = new Note();
			var expected = note.GetModificationTime();

			// Act
			note.SetCategory(Category.Documents);
			var actual = note.GetModificationTime();

			// Assert
			Assert.That(expected, Is.LessThan(actual));
		}
	}
}
