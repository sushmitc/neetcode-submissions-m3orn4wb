class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n < 0:
            return 1 / self.Helper(x, abs(n))
        return self.Helper(x, n)

    def Helper(self, x, n):
        if x == 0:
            return 0
        if n == 0:
            return 1
        
        half = self.Helper(x, n // 2)
        if n % 2 == 0:
            return half * half
        else:
            return half * half * x