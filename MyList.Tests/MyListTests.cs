using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionSolutions.Tests
{
	[TestClass]
	public class MyListTests
	{
		[TestMethod]
		public void 代刚MyList_Append计程node穦琌硂()
		{
			// arrange
			var sut = new MyList();

			var expected = 123;

			// act
			sut.Append(123);

			var actual = sut.Last.Value;

			// assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void 代刚MyList_秨﹍FirstのLast常穦Null()
		{
			// arrange
			var sut = new MyList();

			// act
			var actualFirst = sut.First;
			var actualLast = sut.Last;

			// assert
			Assert.IsNull(actualFirst);
			Assert.IsNull(actualLast);
		}

		[TestMethod]
		public void 代刚MyList_ぃ恨Append碭计_材穦琌程计()
		{
			// arrange
			var sut = new MyList();

			var expected = 1;
			// act
			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			var actual = sut.First.Value;

			// assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void 代刚MyList_Find计т才竊翴()
		{
			// arrange
			var sut = new MyList();

			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			var findValue = 2;
			var expected = 2;

			// act
			var node = sut.Find(findValue);

			var actual = node.Value;

			// assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void 代刚MyList_Findтぃ计穦肚Null()
		{
			// arrange
			var sut = new MyList();

			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			var findValue = 4;

			// act
			var actual = sut.Find(findValue);

			// assert
			Assert.IsNull(actual);
		}

		[TestMethod]
		public void 代刚MyList_Delete﹃い碞тぃ()
		{
			// arrange
			var sut = new MyList();

			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			var deleteValue = 1;

			// act
			sut.Delete(deleteValue);

			var actual = sut.Find(deleteValue);

			// assert
			Assert.IsNull(actual);
		}

		[TestMethod]
		public void 代刚MyList_竊翴タ絋眔﹃计()
		{
			// arrange
			var sut = new MyList();

			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			var expected = 3;

			// act
			var actual = sut.Count;

			// assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void 代刚MyList_埃竊翴タ絋眔﹃计()
		{
			// arrange
			var sut = new MyList();

			sut.Append(1);
			sut.Append(2);
			sut.Append(3);

			sut.Delete(2);

			var expected = 2;

			// act
			var actual = sut.Count;

			// assert
			Assert.AreEqual(expected, actual);
		}
	}
}
