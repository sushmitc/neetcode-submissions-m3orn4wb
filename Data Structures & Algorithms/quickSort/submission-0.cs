// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        if(pairs is null || pairs.Count == 0) return new();

        return QuickSortPairs(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> QuickSortPairs(List<Pair> pairs, int s, int e){
        if(e - s + 1 <= 1) return pairs;

        var pivot = pairs[e];
        var left = s;

        for(int i = s; i <= e; i++){
            if(pairs[i].Key < pivot.Key){
                (pairs[left], pairs[i]) = (pairs[i], pairs[left]);
                left++;
            }
        }

        (pairs[left], pairs[e]) = (pairs[e], pairs[left]);

        QuickSortPairs(pairs, s, left - 1);
        QuickSortPairs(pairs, left + 1, e);

        return pairs;
    }
}
