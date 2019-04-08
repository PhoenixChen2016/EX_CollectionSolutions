using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyArray.Tests
{
    [TestClass]
    public class MyArrayTests
    {
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
        public void ����MyArray_Remove���w�����|���\()
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
        public void ����MyArray_Remove���ަp�G�j��}�C�j�p�|���~()
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
        public void ����MyArray_Remove���ަp�G���t�Ʒ|���~()
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
        public void ����MyArray_��s�}�C���ȷ|���`()
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
        public void ����MyArray_��s�}�C���ެ��t�Ʒ|���~()
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
        public void ����MyArray_��s�}�C���޶W�LLength�|���~()
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
        public void ����MyArray_���ޤl�i�H���o���w������()
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
        public void ����MyArray_���ޤl���w�t�Ʒ|���~()
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
        public void ����MyArray_���ޤl���w�W�L�|���~()
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
    }
}
