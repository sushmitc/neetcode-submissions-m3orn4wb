public class KthLargest {
    private readonly int[] _heap;
    private int _size;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        _k = k;
        _heap = new int[_k + 1];
        _size = 0;

        foreach(var num in nums){
            Add(num);
        }
    }
    
    public int Add(int val) {
        if(_size < _k){
            ++_size;
            _heap[_size] = val;            
            bubbleUp(_size);
        }
        else if(val > _heap[1]){
            _heap[1] = val;
            bubbleDown(1);
        }

        return _heap[1];
    }

    private void bubbleUp(int index){
        while(index > 1){
            int parentNodeIndex = index / 2;
            if(_heap[parentNodeIndex] > _heap[index]){
                (_heap[parentNodeIndex], _heap[index]) = (_heap[index], _heap[parentNodeIndex]);
                index = parentNodeIndex;
            }
            else{
                break;
            }
        }
    }

    private void bubbleDown(int index ){
        while(index * 2 <= _size){ // While node has at least one child
            int leftChild = index * 2;
            int rightChild = index * 2 + 1;
            int smallest = index;
            
            // Find the smallest among node and its children
            if(leftChild <= _size && _heap[leftChild] < _heap[smallest]){
                smallest = leftChild;
            }
            
            if(rightChild <= _size && _heap[rightChild] < _heap[smallest]){
                smallest = rightChild;
            }
            
            // If node is already the smallest, heap property is satisfied
            if(smallest == index){
                break;
            }
            
            // Swap with the smallest child
            (_heap[index], _heap[smallest]) = (_heap[smallest], _heap[index]);
            index = smallest;
        }
    }
}
