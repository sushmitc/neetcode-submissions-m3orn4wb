// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        var pairsList = new List<List<Pair>>();
        
        if(pairs.Count == 0) return pairsList;

        pairsList.Add(new List<Pair>(pairs));
        for(int i = 1; i < pairs.Count; i++){
            int j = i-1; 
            while(j >= 0 && pairs[j].Key > pairs[j+1].Key){
                var temp = pairs[j+1];
                pairs[j+1] = pairs[j];
                pairs[j] = temp;
                j--;
            }

            pairsList.Add(new List<Pair>(pairs));
        }

        return pairsList;
    }
}
