using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        public RecursiveCalc calc;

        public UnitTest1(){
            calc = new RecursiveCalc();
        }
        [Fact]
        // this test is failed, FibonacciRec is not returning fibonnaci numbers, it returns 0 if numFibs is 0, if numFibs>0 it returns 1.
        public void FibonnacciRecTest(){
            Assert.Equal(0,calc.FibonacciRec(1,1,0));
            Assert.Equal(1,calc.FibonacciRec(1,1,1));
            Assert.Equal(1,calc.FibonacciRec(1,1,2));
            Assert.Equal(2,calc.FibonacciRec(1,1,3));
            Assert.Equal(3,calc.FibonacciRec(1,1,4));
            Assert.Equal(5,calc.FibonacciRec(1,1,5));
            Assert.Equal(8,calc.FibonacciRec(1,1,6));
        }
        [Fact]
        public void FactorialRecTest(){
            Assert.Equal(1,calc.FactorialRec(0,1));
            Assert.Equal(1,calc.FactorialRec(1,1));
            Assert.Equal(2,calc.FactorialRec(2,1));
            Assert.Equal(6,calc.FactorialRec(3,1));
            Assert.Equal(24,calc.FactorialRec(4,1));
            Assert.Equal(120,calc.FactorialRec(5,1));
            Assert.Equal(720,calc.FactorialRec(6,1));
        }
        [Fact]
        public void PrimeCheckRecTest(){
            Assert.Equal(false,calc.PrimeCheckRec(1,2));
            Assert.Equal(true,calc.PrimeCheckRec(2,2));
            Assert.Equal(true,calc.PrimeCheckRec(3,2));
            Assert.Equal(false,calc.PrimeCheckRec(4,2));
            Assert.Equal(true,calc.PrimeCheckRec(5,2));
            Assert.Equal(false,calc.PrimeCheckRec(6,2));
            Assert.Equal(false,calc.PrimeCheckRec(100,2));
        }
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(100)]
        public void PrimeCheckRecTestTheoryFalse(int value){
            Assert.False(calc.PrimeCheckRec(value,2));
        }
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void PrimeCheckRecTestTheoryTrue(int value){
            Assert.True(calc.PrimeCheckRec(value,2));
        }
        [Fact]
        public void DivideByZeroExceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(9, 0));
        }
    }
}
