class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        n = len(nums)
        pre = [0] * n
        post = [0] * n
        res = [0] * n

        pre[0] = 1
        post[n - 1] = 1

        for i in range(1, n):
            pre[i] = pre[i - 1] * nums[i - 1]
        for i in range(n - 2, -1, -1):
            post[i] = post[i + 1] * nums[i + 1]
        for i in range(n):
            res[i] = post[i] * pre[i]
        return res
        