class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        res = []

        left = 0
        right = len(numbers) - 1

        while left < right:
            val = numbers[left] + numbers[right]

            if val == target:
                res.append(left + 1)
                res.append(right + 1)
                break
            if val < target:
                left += 1
            else:
                right -= 1
        return res
            