using System;
using Xunit;

namespace UnitTests
{
    public class FibonacciTest
    {
        private FibonacciSolution.Fibonacci _sut;
        public FibonacciTest()
        {
            _sut = new FibonacciSolution.Fibonacci();
        }

        [Fact]
        public void Should_return_ZERO()
        {
            Assert.Equal(0, _sut.GetNthNumber(0));
        }

        [Fact]
        public void Should_return_ONE()
        {
            Assert.Equal(1, _sut.GetNthNumber(1));
        }

        [Fact]
        public void Should_return_TWO()
        {
            Assert.Equal(1, _sut.GetNthNumber(2));
        }

        [Fact]
        public void Should_return_THREE()
        {
            Assert.Equal(2, _sut.GetNthNumber(3));
        }

        [Fact]
        public void Should_return_FOUR()
        {
            Assert.Equal(3, _sut.GetNthNumber(4));
        }

        [Fact]
        public void Should_return_FIVE()
        {
            Assert.Equal(5, _sut.GetNthNumber(5));
        }

        [Fact]
        public void Should_return_TEN()
        {
            Assert.Equal(55, _sut.GetNthNumber(10));
        }

        [Fact]
        public void Should_return_ArgumentError()
        {
            Assert.Throws<ArgumentException>(() => _sut.GetNthNumber(-1));            
        }

        [Fact]
        public void Should_return_55()
        {
            Assert.Equal("55", _sut.Print(10));
        }

        [Fact]
        public void Should_return_144()
        {
            Assert.Equal(144, _sut.GetNthNumber(12));
        }

        [Fact]
        public void Should_return_28657()
        {
            Assert.Equal(28657, _sut.GetNthNumber(23));
        }
    }
}
