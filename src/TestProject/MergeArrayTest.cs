using MergeArrays.Code;

namespace TestProject
{
    public class MergeArrayTest
    {
        [Theory]
        [InlineData(new int[4] {1,2,3,4}, new int[5] { 6, 7, 10, 12, 13 }, new int[9] { 1, 2, 3, 4, 6, 7, 10, 12, 13 })]
        [InlineData(new int[3] {3,2,1}, new int[2] { 4, 5 }, new int[5] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[1] {1}, new int[1] { 2 }, new int[2] { 1, 2 })]
        public void Merge_Arrays_SolutionTwo_PriorityQueue_Test(int[] nums1, int[] nums2, int[] expectedResult)
        {
            //Arrange
            SolutionTwo myClass = new SolutionTwo();

            //Act
            var result = myClass.MergeArraysIntoOneArray(nums1, nums2);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Assert.Equal(String.Join("-", expectedResult), String.Join("-", result));
        }

        [Theory]
        [InlineData(new int[4] { 1, 2, 3, 4 }, new int[5] { 6, 7, 10, 12, 13 }, new int[9] { 1, 2, 3, 4, 6, 7, 10, 12, 13 })]
        [InlineData(new int[3] { 3, 2, 1 }, new int[2] { 4, 5 }, new int[5] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[1] { 1 }, new int[1] { 2 }, new int[2] { 1, 2 })]
        public void Merge_Arrays_SolutionTree_WhileWithOneItem_Test(int[] nums1, int[] nums2, int[] expectedResult)
        {
            //Arrange
            SolutionThree myClass = new SolutionThree();

            //Act
            var result = myClass.MergeArraysIntoOneArray(nums1, nums2);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Assert.Equal(String.Join("-", expectedResult), String.Join("-", result));
        }

    }
}