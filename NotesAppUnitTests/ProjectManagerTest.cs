﻿using System;
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
		[Test(Description="Тест сеттера и геттера _path")]
		public void TestPathSetGet()
		{
			var expected=@".\"
		}
	}
}
