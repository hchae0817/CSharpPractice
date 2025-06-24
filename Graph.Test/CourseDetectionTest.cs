using Graph;
using Xunit;
using System;
using System.Xml.Linq;

namespace Graph.Test
{


    public class CourseDetectionTest
    {
        public static IEnumerable<object[]> EmptyTestData =>
            new List<object[]>
            {
                new object[] { 3, new int[][] { }, true },
                new object[] { 1, new int[][] { }, true }
            };

        public static IEnumerable<object[]> CycleTestData =>
           new List<object[]>
           {
                new object[] { 5, new int[][] { new int[] { 2, 1 }, new int[] { 3, 4 }, new int[] { 4, 3 } }, false },
                new object[] { 2, new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } }, false }
           };

        public static IEnumerable<object[]> ValidTestData =>
            new List<object[]>
            {
                new object[] { 4, new int[][] { new int[] { 1, 0 }, new int[] { 2, 1 }, new int[] { 3, 2 } }, true }
            };

        [Theory]
        [MemberData(nameof(EmptyTestData))]
        public void EmptyTest(int numCourses, int[][] prerequisites, bool expected)
        {
            // Act
            bool result = CourseDetection.GetResult(prerequisites, numCourses);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(CycleTestData))]
        public void TestGetResultWithNodes(int numCourses, int[][] prerequisites, bool expected)
        {
            // Act
            bool result = CourseDetection.GetResult(prerequisites, numCourses);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ValidTestData))]
        public void TestGetResultWithNodesCycle(int numCourses, int[][] prerequisites, bool expected)
        {
            // Act
            bool result = CourseDetection.GetResult(prerequisites, numCourses);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}