using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            RecursiveCalc calc = new RecursiveCalc();

            Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(9, 1));
        }

        Creating Unit Test for FibonacciRec.
        [Fact]
        public void FibonacciRecTest1()
        {   // PASSES THE TEST.
            // Test when numFib = 1 should return 1
            RecursiveCalc FibCheck = new RecursiveCalc();
            int check = FibCheck.FibonacciRec(0,0,1);
            Assert.Equal(1,check);
        }

        [Fact]
        public void FibonacciRecTest2()
        {   // PASSES THE TEST.
            // Test when numFib = 2 should return 1
            RecursiveCalc FibCheck  = new RecursiveCalc();
            int check = FibCheck.FibonacciRec(0,0,2);
            Assert.Equal(1,check);
        }

        [Fact]
        public void FibonacciRecTest3()
        {   // PASSES THE TEST.
            // Test when numFib = >2 should return 1
            RecursiveCalc FibCheck = new RecursiveCalc();
            int check = FibCheck.FibonacciRec(0,0,3);
            Assert.Equal(1,check);
        }

        [Fact]
        public void FibonacciRecTest4()
        }   // Test when numFib = -3 should return 0
            RecursiveCalc FibCheck = new RecursiveCalc();
            int check = FibCheck.FibonacciRec(0,0,-3);
            Assert.Equal(0,check);
        }

        [Fact]
        public void FibonacciRecTest5()
        {   // FAILS THE TEST. 
            // Test when numFib = 0 should return 0
            RecursiveCalc FibCheck = new RecursiveCalc();
            int check = FibCheck.FibonacciRec(0,0,0);
            Assert.Equal(0,check);
        }

        [Fact]
        public void FactorialRecTest1()
        {   
            RecursiveCalc FacCheck = new RecursiveCalc(); 
            int check = FacCheck.FactorialRec(0,1);
            Assert.Equal(1, check);
        }

        [Fact]
        public void FactorialRecTest2()
        {   
            RecursiveCalc FacCheck = new RecursiveCalc(); 
            int check = FacCheck.FactorialRec(1,1);
            Assert.Equal(1, check);
        }

        [Fact]
        public void PrimeCheckRecTest1() 
        {
            // Should Fail and Throw DivideByZeroException
            RecursiveCalc PrimeCheck = new RecursiveCalc(); 
            Assert.Throws<System.DivideByZeroException>(() => PrimeCheck.PrimeCheckRec(1, 0));
        }

        [Fact]
        public void PrimeCheckRecTest2()
        {   
            RecursiveCalc PrimeCheck = new RecursiveCalc(); 
            int check = PrimeCheck.PrimeCheckRec(5,1);
            Assert.Equal(1, check);
        }
    }
}
