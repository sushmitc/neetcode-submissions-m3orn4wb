public class Solution {
    private int[][] _heap;
    private int _size;

    public int[][] KClosest(int[][] points, int k) {
        _size = 0;
        _heap = new int[k][];

        for(int i = 0; i < points.Length; i++)
        {
            if(_size < k){
                //add an entry to heap
                _heap[_size] = points[i];
                // bubble up
                BubbleUp(_heap, _size);
                _size++;
            }
            else
            {
                if(CalculateDistance(points[i]) < CalculateDistance(_heap[0]))
                {
                    _heap[0] = points[i];
                    BubbleDown(_heap, 0);
                }
            }
        }

        return _heap;
    }

    private void BubbleUp(int[][] heap, int index)
    {
        while(index > 0)
        {
            int parentIndex = index / 2;
            
            if(CalculateDistance(heap[parentIndex]) < CalculateDistance(heap[index]))
            {
                (heap[parentIndex], heap[index]) = (heap[index], heap[parentIndex]);
            }
            else
            {
                break;
            }

            index = parentIndex;
        }
    }

    private void BubbleDown(int[][] heap, int index)
    {
        while(index * 2 + 1 < heap.Length)
        {
            int largestIndex = index;
            int leftIndex = index * 2 + 1;
            int rightIndex = index * 2 + 2;
            
            if(leftIndex < heap.Length && CalculateDistance(heap[leftIndex]) > CalculateDistance(heap[largestIndex]))
            {
                largestIndex = leftIndex;
            }
            
            if(rightIndex < heap.Length && CalculateDistance(heap[rightIndex]) > CalculateDistance(heap[largestIndex]))
            {
                largestIndex = rightIndex;
            }

            if(largestIndex == index) break;

            (heap[largestIndex], heap[index]) = (heap[index], heap[largestIndex]);
            index = largestIndex;
        }
    }

     private double CalculateDistance(int[] point) => Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
}
