class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        res, curr = [], []
        nums.sort()
        self.helper(nums, 0, curr, res)
        return res
    
    def helper(self, nums, index, curr, res):

        if index >= len(nums):
            res.append(curr[:])
            return

        #take nums[i]
        curr.append(nums[index])
        self.helper(nums, index + 1, curr, res)
        curr.pop()

        #dont take nums[i]
        while index + 1 < len(nums) and nums[index] == nums[index + 1]:
            index += 1

        self.helper(nums, index + 1, curr, res)


    

        