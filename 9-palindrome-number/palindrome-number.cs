public class Solution {
    public bool IsPalindrome(int x) {
        string valStr = x.ToString();
        List<char> inv = new List<char>();

        for (int i = valStr.Length - 1; i >= 0; i--) {
            inv.Add(valStr[i]);
        }

        string reversedStr = new string(inv.ToArray());
        return valStr == reversedStr;
    }
}
