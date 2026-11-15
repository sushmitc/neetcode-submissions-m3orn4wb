class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        s = 0
        l = 0
        r = 0
        min_len = float('inf')
        while r < len(nums):
            s += nums[r]
            while s >= target:
                min_len = min(min_len, r - l + 1)
                s -= nums[l]
                l += 1
            r += 1
        return min_len if min_len != float('inf') else 0