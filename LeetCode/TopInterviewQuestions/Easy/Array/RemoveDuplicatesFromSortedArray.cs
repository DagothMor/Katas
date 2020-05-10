using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TopInterviewQuestions.Easy.Array
{
    /// <summary>
    /// Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
    /// 
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// </summary>
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int temp;
            int shiftedindex = nums.Length-1;
            int answer=0;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = nums[i];
                answer++;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] == temp)
                    {
                        i = j;
                    }
                }
            }
            return answer;

        }
    }
}
