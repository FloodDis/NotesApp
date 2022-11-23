using NUnit.Framework;
using NotesAppClasses; 
namespace NotesAppUnitTests
{
	[TestFixture]
	public class NoteTest
	{
		[Test(Description ="���� ������� _name")]
		public void TestNameSet()
		{
			var expected = "New note";

			var note = new Note();
			note.SetName("New note");
			var actual = note.GetName();

			Assert.AreEqual(expected, actual);
		}
	}
}