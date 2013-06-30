using System;
using NUnit.Framework;

namespace csharp
{
	[TestFixture()]
	public class GameOfLifeTest
	{
		[Test()]
		public void Fails_Miserably ()
		{
			Assert.AreEqual (0, 1);
		}
	}
}

