using LeetSharp.Core;

namespace LeetSharp.Problems;
/*
'''
# Problem
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

# Constraints:
    2 <= nums.length <= 10^4
    -10^9 <= nums[i] <= 10^9
    -10^9 <= target <= 10^9
    Only one valid answer exists.

# Intuition
First thought is to use a brute force approach, which is to check all pairs of numbers in the array and see if they add up to the target.
Now this solution would not be very efficient, as it would take O(n^2) time complexity. 
Analizing the problem, that the problem is really [Target - number=X] so we can store each number in a hash table and check if the target - number exists in the hash table we have the answer. 

# Approach
tne way to solve this problem is to use a hash table to store the numbers we have seen so far and their indices.

# Implementation
- Space complexity:
    - We can use a hash table to store the numbers we have seen so far and their indices.
    - This will allow us to check if the complement of the current number (target - nums[i]) exists in the hash table in O(1) time.
    - The space complexity is O(n) where n is the number of elements in the array.
- Time complexity:
 
*/

public class TwoSumProblem : ISolutionRunner
{
    public string Name => "Two Sum";
    public string Description => "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.";
    public string[] Tags => new[] { "C#", "Array", "Sum", "indices" };
   
    public int[] nums = new int[0];
    public int target = 0;  

    public ISolutionResult Run()
    {
        // Example usage
        nums = new int[]{ 2, 7, 11, 15 };
        target = 9;
        var result = TwoSum(nums, target);
        return new SolutionResult($"Indices: {string.Join(", ", result)}");
    }

    public int[] TwoSum(int[] nums, int target)
    {
        IDictionary<int, int> numbersSeen = new Dictionary<int, int>();
        int numsSize = nums.Length;
        for (int i = 0; i < numsSize; i++)
        {
            if (numbersSeen.ContainsKey(target - nums[i]))
            {
                return new[] { numbersSeen[target - nums[i]], i };
            }
            else if (!numbersSeen.ContainsKey(nums[i]))
            {
                numbersSeen.Add(nums[i], i);
            }
        }

        return new int[0];
    }

}

