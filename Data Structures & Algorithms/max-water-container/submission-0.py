class Solution:
    def maxArea(self, heights: List[int]) -> int:
        l, r = 0, len(heights) - 1

        max_vol = 0
        while l < r:
            length = min(heights[l], heights[r])
            breadth = r - l

            max_vol = max(max_vol, length * breadth)

            if heights[l] <= heights[r]:
                l += 1
            else:
                r -= 1
                
        return max_vol
            


