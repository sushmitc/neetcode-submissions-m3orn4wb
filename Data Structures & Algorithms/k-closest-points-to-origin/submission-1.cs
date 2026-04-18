public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int n = points.Length;

        for(int i = n/2; i >= 0; i--)
        {
            HeapifyDown(points, i, n);
        }

        int[][] result = new int[k][];
        int heapSize = n;

        for (int i = 0; i < k; i++) {
            result[i] = points[0];

            heapSize--;
            points[0] = points[heapSize];
            HeapifyDown(points, 0, heapSize);
        }

        return result;
    }

    private void HeapifyDown(int[][] points, int index, int size)
    {
        while(index * 2 < size){
            int smallestIndex = index;
            int leftIndex = index * 2 + 1;
            int rightIndex = index * 2 + 2;

            if(leftIndex < size && CalculateDistance(points[leftIndex]) < CalculateDistance(points[smallestIndex])){
                smallestIndex = leftIndex;
            }

            if(rightIndex < size && CalculateDistance(points[rightIndex]) < CalculateDistance(points[smallestIndex])){
                smallestIndex = rightIndex;
            }

            if(smallestIndex == index) break;

            (points[smallestIndex], points[index]) = (points[index], points[smallestIndex]);
            index = smallestIndex;
        }
    }

    private double CalculateDistance(int[] point) => Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
}
