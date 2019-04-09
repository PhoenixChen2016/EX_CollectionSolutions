using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

namespace CollectionSolutions.Tests
{
    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        public void 測試MyStack_Push數字後Length會增加()
        {
            // arrange
            var sut = new MyStack();

            var expected = 3;

            // act
            sut.Push(1);
            sut.Push(2);
            sut.Push(3);

            var actual = sut.Length;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 測試MyStack_Pop會取得最後Push的數字()
        {
            // arrange
            var sut = new MyStack();

            var expected = 3;

            // act 
            sut.Push(1);
            sut.Push(2);
            sut.Push(3);

            var actual = sut.Pop();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 測試MyStack_Pop空的Stack會發生錯誤()
        {
            // arrange
            var sut = new MyStack();

            // act
            Action action = () => sut.Pop();

            // assert
            action.Should().Throw<IndexOutOfRangeException>();
        }
    }
}
