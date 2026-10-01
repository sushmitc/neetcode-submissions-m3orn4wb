class NumArray:

    def __init__(self, nums: List[int]):
        self.nums = nums
        self.prefix = self.GetAddPrefixList(nums)
    
    def GetAddPrefixList(self, nums):
        prefix = []
        total = 0

        for n in nums:
            total += n
            prefix.append(total)

        return prefix

    def sumRange(self, left: int, right: int) -> int:
        a = self.prefix[right]
        b = self.prefix[left - 1] if left > 0 else 0

        return a - b
        


# Your NumArray object will be instantiated and called as such:
# obj = NumArray(nums)
# param_1 = obj.sumRange(left,right)