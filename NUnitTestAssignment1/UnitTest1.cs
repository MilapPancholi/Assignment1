using NUnit.Framework;
using Assignment1;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTriangle_Input_10_10_10_Output_Equilateral()
        {
            Assert.AreEqual(TriangleSolver.Analyze(10,10,10),"Equilateral");
        }

        [Test]
        public void TestTriangle_Input_15_10_5_Output_Scalene()
        {
            Assert.AreEqual(TriangleSolver.Analyze(15, 10, 5), "Invalid");
        }

        [Test]
        public void TestTriangle_Input_10_10_5_Output_Scalene()
        {
            Assert.AreEqual(TriangleSolver.Analyze(10, 10, 5), "Isosceles");
        }

        [Test]
        public void TestTriangle_Input_0_0_5_Output_Invalid()
        {
            Assert.AreEqual(TriangleSolver.Analyze(0, 0, 0), "Invalid");
        }

        [Test]
        public void TestTriangle_Input_M10_1_5_Output_Invalid()
        {
            Assert.AreEqual(TriangleSolver.Analyze(-10, 1, 5), "Invalid");
        }

        [Test]
        public void TestTriangle_Input_1_2_50_Output_Invalid()
        {
            Assert.AreEqual(TriangleSolver.Analyze(1, 2, 50), "Invalid");
        }

        [Test]
        public void TestTriangle_Input_20_20_45_Output_Invalid()
        {
            Assert.AreEqual(TriangleSolver.Analyze(20, 20, 45), "Invalid");
        }

        [Test]
        public void TestTriangle_Input_20_30_50_Output_Scalene()
        {
            Assert.AreEqual(TriangleSolver.Analyze(20, 30, 50), "Invalid");
        }

    }
}