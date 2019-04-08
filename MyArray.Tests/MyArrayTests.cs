using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyArray.Tests
{
    [TestClass]
    public class MyArrayTests
    {
        [TestMethod]
        public void ����MyArray_Insert�Ʀr�|���`()
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
        public void ����MyArray_�q����Insert�Ʀr�|���`()
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
        public void ����MyArray_�q�YInsert�Ʀr�|���`()
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

        [TestMethod]
        public void ����MyArray_Insert�p�Gindex�p��0�|�o�Ϳ��~()
        {
            // arrange
            var sut = new MyArray();

            // act

            Action action = () => sut.Insert(-1, 1);

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [TestMethod]
        public void ����MyArray_Insert�p�Gindex�j��Length�|�o�Ϳ��~()
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
    }
}
