using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);
        
        string answer = "";
        for (int i=0; i<n; i++)
        {
            for (int k=0; k<i+1; k++) answer += "*";
            answer += "\n";
        }

        Console.WriteLine("{0}", answer);
    }
}
