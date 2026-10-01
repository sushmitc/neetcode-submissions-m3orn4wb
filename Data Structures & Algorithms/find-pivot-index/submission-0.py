class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        self.prefix = []
        total = 0

        for n in nums:
            total += n
            self.prefix.append(total)
        
        for i in range(len(nums)):
            left, right = self.GetPrefixSum(i - 1, i)

            if left == right:
                return i
        
        return -1
    
    def GetPrefixSum(self, left_i: int, right_i: int):
        left = self.prefix[left_i] if left_i >= 0 else 0
        right = self.prefix[len(self.prefix) - 1] - self.prefix[right_i]

        return (left, right)
        
        