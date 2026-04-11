public class Solution {
    private List<int> _heap;

    public int LastStoneWeight(int[] stones) {

        _heap = new List<int>{0};

        for(int i = 0; i < stones.Length; i++){
            _heap.Add(stones[i]);
            HeapifyUp(i + 1);
        }

        while(_heap.Count > 2){
            int largestWeight = RemoveMax();
            int secondLargestWeight = RemoveMax();

            int diff = largestWeight - secondLargestWeight;
            if(diff > 0){
                _heap.Add(diff);
                HeapifyUp(_heap.Count - 1);
            }         
        }

        return _heap.Count > 1 ? _heap[1] : 0;
    }

    private void HeapifyUp(int index){
        while(index > 1){
            int parentNode = index / 2;
            
            if(_heap[parentNode] < _heap[index]){
                (_heap[parentNode], _heap[index]) = (_heap[index], _heap[parentNode]);
                index = index / 2;
            }
            else{
                break;
            }
        }
    }

    private void HeapifyDown(int index){
        while(index * 2 < _heap.Count){
            int largestIndex = index;
            int leftNodeIndex = index * 2;
            int rightNodeIndex = index * 2 + 1;

            if(_heap[largestIndex] < _heap[leftNodeIndex]){
                largestIndex = leftNodeIndex;
            }
            if(rightNodeIndex < _heap.Count && _heap[largestIndex] < _heap[rightNodeIndex]){
                largestIndex = rightNodeIndex;
            }

            if(largestIndex == index) break;

            (_heap[index], _heap[largestIndex]) = (_heap[largestIndex], _heap[index]);
            index = largestIndex;
        }

    }

    private int RemoveMax(){
        var res = _heap[1];
        _heap[1] = _heap[_heap.Count - 1];
        _heap.RemoveAt(_heap.Count - 1);
        if (_heap.Count > 1) HeapifyDown(1);
        return res;
    }
}