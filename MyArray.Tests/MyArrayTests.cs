using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyArray;

namespace MyArray.Tests
{
    [TestClass]
    public class MyArrayTests
    {
        [TestMethod]
        public void 代刚MyArray_Insert计穦タ盽()
        {
            // arrange
            var sut = new MyArray();

            var expected = new[] { 1, 3, 5, 7, 9 };

            // act
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            var actual = sut.ToArray();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 代刚MyArray_眖い丁Insert计穦タ盽()
        {
            // arrange
            var sut = new MyArray();

            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 7);
            sut.Insert(3, 9);

            var expected = new[] { 1, 3, 5, 7, 9 };

            // act
            sut.Insert(2, 5);

            var actual = sut.ToArray();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
