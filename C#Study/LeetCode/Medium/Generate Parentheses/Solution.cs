public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        GenerateParenthesisHelper(n, 0, 0, "", result);
        return result;
    }
    
    static void GenerateParenthesisHelper(int n, int open, int close, string current, List<string> result)
    {
        if (current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }

        if (open < n)
        {
            GenerateParenthesisHelper(n, open + 1, close, current + "(", result);
        }

        if (close < open)
        {
            GenerateParenthesisHelper(n, open, close + 1, current + ")", result);
        }
    }
}
