class NumMatrix:

    def __init__(self, matrix: List[List[int]]):
        self.arr = self.GetPrefixMatix(matrix)
    
    def GetPrefixMatix(self, matrix: List[List[int]]) -> List[List[int]]:
        
        prefix_matrix = []

        if len(matrix) == 0:
            return prefix_matrix

        for row in range(len(matrix)):
            arr = []
            total = 0
            for col in range(len(matrix[0])):
                total += matrix[row][col]
                arr.append(total)
            
            prefix_matrix.append(arr[:])
        
        return prefix_matrix

    def sumRegion(self, row1: int, col1: int, row2: int, col2: int) -> int:
        ans = 0
        
        for i in range(row1, row2 + 1):
            a = self.arr[i][col2]
            b = self.arr[i][col1 - 1] if col1 > 0 else 0

            ans = ans + (a - b)
        
        return ans

        


# Your NumMatrix object will be instantiated and called as such:
# obj = NumMatrix(matrix)
# param_1 = obj.sumRegion(row1,col1,row2,col2)