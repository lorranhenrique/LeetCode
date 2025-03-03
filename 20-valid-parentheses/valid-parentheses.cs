public class Solution {
    public bool IsValid(string s) {
        int n = s.Length;
        if (n % 2 != 0) return false;

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> charactersMap = new Dictionary<char, char> {
            { ')', '(' }, { ']', '[' }, { '}', '{' }
        };    

        foreach(char value in s){
            if (charactersMap.TryGetValue(value, out char expected)) {              
                if (stack.Count == 0 || stack.Peek() != expected) return false;
                    stack.Pop();
                } else {
                    stack.Push(value);
            }
        }    
        return stack.Count == 0;
    }
}