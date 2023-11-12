public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>();
        }

        Dictionary<char, string> digitMapping = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        List<string> combinations = new List<string>();
        Backtrack(0, new List<char>(), digits, digitMapping, combinations);

        return combinations;
    }

    
    static void Backtrack(int index, List<char> path, string digits, Dictionary<char, string> digitMapping, List<string> combinations)
    {
        if (index == digits.Length)
        {
            combinations.Add(new string(path.ToArray()));
            return;
        }

        char currentDigit = digits[index];
        string letters = digitMapping[currentDigit];

        foreach (char letter in letters)
        {
            path.Add(letter);
            Backtrack(index + 1, path, digits, digitMapping, combinations);
            path.RemoveAt(path.Count - 1);
        }
    }
}
