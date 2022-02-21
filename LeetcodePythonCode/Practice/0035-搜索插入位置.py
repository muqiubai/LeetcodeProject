from typing import List


class Solution:
    i = 3.1514;
    def searchInsert(self, nums: List[int], target: int) -> int:

        left,right = 0,len(nums) - 1;

        while(left <= right):
            mid = (left + right)//2;

            if(nums[mid] == target):
                return mid;
            elif(nums[mid] < target):
                left = mid + 1;
            else:
                right = mid - 1;

        return left


solution = Solution();

list = [1,3,5,6]

print(solution.i);
print(solution.searchInsert(list,5));