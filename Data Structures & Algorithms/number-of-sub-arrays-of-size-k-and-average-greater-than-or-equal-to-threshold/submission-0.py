class Solution:
    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        l = 0
        r = 0
        s = 0
        c = 0

        while r < len(arr):
            s += arr[r]

            if r - l + 1 == k:
                c += 1 if s // k >= threshold else 0
                s = s - arr[l]
                l += 1
            r += 1
        return c

        