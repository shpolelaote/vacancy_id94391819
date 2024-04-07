using AreaCalculate;
using System;
using System.Diagnostics.Metrics;

namespace TestTriangle
{
    [TestClass]
    public class UnitTest1
    {
        // testing without expected exceptions
        [DataTestMethod]
        [DynamicData(nameof(MeasurementData), DynamicDataSourceType.Method)]
        public void ProperMeasurements(double[] measurements, double expected)
        {
            double actual = AreaCalculator.ShapeArea(measurements);
            Assert.AreEqual(expected, actual);
        }
        static IEnumerable<object[]> MeasurementData()
        {
            yield return new object[] { new double[] { 5 }, Math.PI * 25 };
            yield return new object[] { new double[] { 0 }, 0 };
            yield return new object[] { new double[] { 3 }, Math.PI * 9 };
            yield return new object[] { new double[] { 3, 4, 5 }, 6 };
            yield return new object[] { new double[] { 3, 4, 5 }, 6 };
            yield return new object[] { new double[] { 1, 2, 3 }, 0 };
        }

        // testing for proper output exceptions
        [TestMethod]
        public void NegativeMeasurement1()
        {
            double[] M = { -1, -6, 5 };
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (Exception e)
            {
                if (e.Message == "Only positive input measurements are allowed.")
                {
                    return;
                }
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NegativeMeasurement2()
        {
            double[] M = { -19};
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (Exception e)
            {
                if (e.Message == "Only positive input measurements are allowed.")
                {
                    return;
                }
                Assert.Fail();
            }
            Assert.Fail();
        }
        // trying to input 0, 2, 4 or more measurements
        // those cases are not yet implemented
        [TestMethod]
        public void NotImplementedShape1()
        {
            double[] M = { };
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (NotImplementedException)
            {
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NotImplementedShape2()
        {
            double[] M = { 9, 5};
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (NotImplementedException)
            {
                return;
            }
            Assert.Fail();
        }
        [TestMethod]
        public void NotImplementedShape3()
        {
            double[] M = { 9, 5, 88, 23 };
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (NotImplementedException)
            {
                return;
            }
            Assert.Fail();
        }
        // check if the method handles unreal triangles
        [TestMethod]
        public void UnrealTriangle1()
        {
            double[] M = { 1, 1, 999 };
            try
            {
                AreaCalculator.ShapeArea(M);
            }
            catch (Exception e)
            {
                if (e.Message == "the triangle doesn't exists")
                    return;
            }
            Assert.Fail();
        }
    }
}