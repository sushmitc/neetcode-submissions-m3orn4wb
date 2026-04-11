public class Solution {

    public string Encode(IList<string> strs) {
        var codedString = new StringBuilder();

        for(int i = 0; i < strs.Count; i++){
            codedString.Append($"{strs[i].Length}#{strs[i]}");
        }

        Console.WriteLine(codedString.ToString());

        return codedString.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        var len = 0;
        
        for(int i = 0; i < s.Length;){
            Console.WriteLine("i : {0}", i);
            if(s[i] != '#'){
                len = len * 10 + (s[i] - '0');
                i++;
                continue;
            }

            Console.WriteLine("len : {0}", len);
            res.Add(s.Substring(i+1, len));
            i = i + len + 1;  
            len = 0;
        }

        return res;
   }
}
