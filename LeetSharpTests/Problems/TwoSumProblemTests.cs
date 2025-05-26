using LeetSharp.Core;

namespace LeetSharp.Problems.Tests
{
    [TestClass()]
    public class TwoSumProblemTests
    {
        [TestMethod()]
        public void ExecuteTest()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = new int[] { 0, 1 };
            int[] result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void TwoSum_Example2_Test()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] expected = new int[] { 1, 2 };
            int[] result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void TwoSum_Example3_Test()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            int[] expected = new int[] { 0, 1 };
            int[] result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void TwoSum_Example4_Negative_Test()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = new int[] { -4, 2, 5, 7, 9, 1, 0 };
            int target = -3;
            int[] expected = new int[] { 0, 5 };
            int[] result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod()]
        public void TwoSum_NotFound_Test()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = new int[] { 3, 5, 6, 7, 12, 25, 82, 94 };
            int target = 14;
            int[] expected = new int[0];
            int[] result = twoSumProblem.TwoSum(nums, target);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}