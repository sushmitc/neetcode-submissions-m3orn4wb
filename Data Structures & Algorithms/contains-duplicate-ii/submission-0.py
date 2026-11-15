class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        table = {}
        for i in range(len(nums)):
            if nums[i] in table:
                j = table[nums[i]]
                if abs(i - j) <= k:
                    return True
            table[nums[i]] = i
        return False


        