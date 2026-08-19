# Definition for a pair.
# class Pair:
#     def __init__(self, key: int, value: str):
#         self.key = key
#         self.value = value
class Solution:
    def mergeSort(self, pairs: List[Pair]) -> List[Pair]:
        return self.MergeSortPairs(pairs, 0, len(pairs) - 1)

    def MergeSortPairs(self, pairs: List[Pair], left: int, right: int) -> List[Pair]:
        if(left < right):
            mid = (left + right) // 2
            self.MergeSortPairs(pairs, left, mid)
            self.MergeSortPairs(pairs, mid + 1, right)
            self.Merge(pairs, left, mid, right)
        return pairs
    
    def Merge(self, pairs: List[Pair], left: int, mid: int, right: int):
        tempRight = []
        tempLeft= []

        for i in range(left, mid + 1):
            tempLeft.append(pairs[i])
        
        for i in range(mid + 1, right + 1):
            tempRight.append(pairs[i])
        
        i = 0
        j = 0
        k = left

        while i < len(tempLeft) and j < len(tempRight):
            if tempLeft[i].key <= tempRight[j].key:
                pairs[k] = tempLeft[i]
                i += 1
            else:
                pairs[k] = tempRight[j]
                j += 1
            k += 1
    
        # Copy remaining elements
        while i < len(tempLeft):
            pairs[k] = tempLeft[i]
            i += 1
            k += 1
    
        while j < len(tempRight):
            pairs[k] = tempRight[j]
            j += 1
            k += 1

        return pairs

        
