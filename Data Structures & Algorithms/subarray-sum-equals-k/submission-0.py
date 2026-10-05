class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        prefixsum_hashmap = {}
        prefixsum_hashmap[0] = 1

        sum = 0
        res = 0

        for i in range(len(nums)):
            sum += nums[i]
            key = sum - k
            if key in prefixsum_hashmap:
                res += prefixsum_hashmap[key]
            prefixsum_hashmap[sum] = prefixsum_hashmap.get(sum, 0) + 1
        
        return res
