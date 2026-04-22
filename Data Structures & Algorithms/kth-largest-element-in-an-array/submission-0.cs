public class Solution {
    private int[] _heap;
    private int _size;

    public int FindKthLargest(int[] nums, int k) {
        _heap = new int[k];
        _size = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(_size < k)
            {
                _heap[_size] = nums[i];
                BubbleUp(_heap, _size);
                _size++;
            }
            else
            {
                if(nums[i] > _heap[0])
                {
                    _heap[0] = nums[i];
                    BubbleDown(_heap, 0);
                }
            }
        }

        return _heap[0];
    }

    private void BubbleUp(int[] _heap, int index)
    {
        while(index > 0)
        {
            int parentIndex = index / 2;

            if(_heap[parentIndex] > _heap[index])
            {
                (_heap[parentIndex], _heap[index]) = (_heap[index], _heap[parentIndex]);
            }
            else
            {
                break;
            }

            index = parentIndex;
        }
    }

    private void BubbleDown(int[] heap, int index)
    {
        while(index * 2 + 1 < heap.Length)
        {
            int smallestIndex = index;
            int leftIndex = index * 2 + 1;
            int rightIndex = index * 2 + 2;
            
            if(leftIndex < heap.Length && heap[leftIndex] < heap[smallestIndex])
            {
                smallestIndex = leftIndex;
            }
            
            if(rightIndex < heap.Length && heap[rightIndex] < heap[smallestIndex])
            {
                smallestIndex = rightIndex;
            }

            if(smallestIndex == index) break;

            (heap[smallestIndex], heap[index]) = (heap[index], heap[smallestIndex]);
            index = smallestIndex;
        }
    }
}
