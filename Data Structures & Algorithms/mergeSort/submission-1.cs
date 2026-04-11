// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {
        if(pairs is null || pairs.Count == 0) return new();

        return MergeSortPairs(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> MergeSortPairs(List<Pair> pairs, int s, int e){
        if(e - s + 1 <= 1) return pairs;

        var m = (e + s) / 2;

        MergeSortPairs(pairs, s, m);
        MergeSortPairs(pairs, m + 1, e);

        MergePairs(pairs, s, m, e);

        return pairs;
    }

    public List<Pair> MergePairs(List<Pair> pairs, int s, int m, int e){
        
        var tempLeftList = new List<Pair>();
        var tempRightList = new List<Pair>();

        //left
        for(int l = s; l <= m; l++){
            tempLeftList.Add(pairs[l]);
        }

        //right
        for(int r = m + 1; r <= e; r++){
            tempRightList.Add(pairs[r]);
        }

        int i = 0;
        int j = 0;
        int k = s;

        while(i < tempLeftList.Count && j < tempRightList.Count){
            if(tempLeftList[i].Key > tempRightList[j].Key) {
                pairs[k] = tempRightList[j];
                j++;
            }else{
                pairs[k] = tempLeftList[i];
                i++;
            }

            k++;
        }

        while(i < tempLeftList.Count){
            pairs[k] = tempLeftList[i];
            i++;
            k++;
        }

        while(j < tempRightList.Count){
            pairs[k] = tempRightList[j];
            j++;
            k++;
        }

        return pairs;
    }
}
