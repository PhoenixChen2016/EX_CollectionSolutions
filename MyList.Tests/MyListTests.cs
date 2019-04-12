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

		[TestMethod]
		public void ����MyList_Find�Ʀr�i�H���ŦX���`�I()
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
		public void ����MyList_Find�䤣��Ʀr�|�^��Null()
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
		public void ����MyList_Delete���C���N�䤣��F()
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
		public void ����MyList_�[�J�`�I�i�H���T�o���C���Ӽ�()
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
		public void ����MyList_�R���`�I��i�H���T�o���C�Ӽ�()
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
