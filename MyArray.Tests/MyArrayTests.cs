using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyArray.Tests
{
    [TestClass]
    public class MyArrayTests
    {
        [TestMethod]
        public void 測試MyArray_Insert如果index大於Length會發生錯誤()
        {
            // arrange
            var sut = new MyArray();

            sut.Insert(0, 3);
            sut.Insert(1, 5);

            // act

            Action action = () => sut.Insert(100, 1);

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_Insert如果index小於0會發生錯誤()
        {
            // arrange
            var sut = new MyArray();

            // act

            Action action = () => sut.Insert(-1, 1);

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_Insert數字會正常()
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
        public void 測試MyArray_Remove指定元素會成功()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            var expected = new[] { 1, 3, 7, 9 };

            // act
            sut.Remove(2);

            var actual = sut.ToArray();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 測試MyArray_Remove索引如果大於陣列大小會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () => sut.Remove(5);

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_Remove索引如果為負數會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () => sut.Remove(-1);

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_更新陣列的值會正常()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            var expected = new[] { 1, 3, 5, 7, 100 };

            // act
            sut[4] = 100;

            var actual = sut.ToArray();

            // assert
            Assert.AreEqual(expected[3], actual[3]);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 測試MyArray_更新陣列索引為負數會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () => sut[-1] = 1;

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_更新陣列索引超過Length會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () => sut[5] = 1;

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_索引子可以取得指定的元素()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            var expected = 3;

            // act
            var actual = sut[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 測試MyArray_索引子指定負數會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () =>
            {
                var test = sut[-1];
            };

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_索引子指定超過會錯誤()
        {
            // arrange
            var sut = new MyArray();
            sut.Insert(0, 1);
            sut.Insert(1, 3);
            sut.Insert(2, 5);
            sut.Insert(3, 7);
            sut.Insert(4, 9);

            // act
            Action action = () =>
            {
                var test = sut[5];
            };

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void 測試MyArray_從中間Insert數字會正常()
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

        [TestMethod]
        public void 測試MyArray_從頭Insert數字會正常()
        {
            // arrange
            var sut = new MyArray();

            sut.Insert(0, 3);
            sut.Insert(1, 5);
            sut.Insert(2, 7);
            sut.Insert(3, 9);

            var expected = new[] { 1, 3, 5, 7, 9 };

            // act
            sut.Insert(0, 1);

            var actual = sut.ToArray();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
