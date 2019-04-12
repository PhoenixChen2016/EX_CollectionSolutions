using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionSolutions.Tests
{
	[TestClass]
	public class MyListTests
	{
		[TestMethod]
		public void ����MyList_Append�Ʀr��̫�@��node���ȷ|�O�o�ӭ�()
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
		public void ����MyList_�@�}�lFirst��Last���|��Null()
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
		public void ����MyList_����Append�X�ӼƦr_�Ĥ@�ӭȷ|�O�̪��J���Ʀr()
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
	}
}
