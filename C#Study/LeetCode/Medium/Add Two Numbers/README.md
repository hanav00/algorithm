# Intuition
My initial approach was to extract the numbers from l1 and l2, add them in reverse order, and then rebuild the linked list to return the answer.

# Approach
In my first attempt, I implemented the code based on my initial thoughts (see the code below). However, when I tested the code, I realized that the numbers could be quite large, as the problem mentioned that the linked list's length could be up to 100. I initially used the int data type, which was insufficient for handling such large numbers. I then switched to using long, and eventually, BigInteger. While these changes made my code accurate, they introduced unnecessary overhead due to the storage of the first number and second number.
Subsequently, I opted for a more efficient approach. I decided to calculate each digit individually and immediately place them in the answer node. This way, I could avoid the need for BigInteger in my code!

# Complexity
- Time complexity: $$O(max(N, M))$$

- Space complexity: $$O(max(N, M))$$

# Code
```
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
using System;

class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;
        int carry = 0; 

        while (l1 != null || l2 != null)
        {
            int x = (l1 != null) ? l1.val : 0; 
            int y = (l2 != null) ? l2.val : 0; 

            int sum = x + y + carry; 
            carry = sum / 10; 
            int digit = sum % 10; 

            current.next = new ListNode(digit);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next; 
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }
        return dummyHead.next;
    }
}
```

# Code Before
```
using System.Numerics;
class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        BigInteger firstNum = 0;
        BigInteger secondNum = 0;

        // Get Number from l1
        BigInteger multiplier = 1; 
        while (l1 != null)
        {
            if (l1.val != 0)
            {
                firstNum += l1.val * multiplier;
            }
            Console.WriteLine(firstNum);
            multiplier *= 10;
            l1 = l1.next;
        }

        // Get Number from l2
        multiplier = 1;
        while (l2 != null)
        {
            if (l2.val != 0)
            {
                secondNum += l2.val * multiplier;
            }
            multiplier *= 10;
            l2 = l2.next;
        }
        BigInteger result = firstNum + secondNum;

        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;

        string resultToString = result.ToString();
        for (int i = resultToString.Length - 1; i >= 0; i--)
        {
            int num = int.Parse(resultToString[i].ToString());
            current.next = new ListNode(num);
            current = current.next;
        }
        return dummyHead.next;
    }
}
```
The answer was accepted, but their were some uneffective points in this code. The first and second numbers' range was to wide, so I had to use Big Integer to get the right numers. BigInteger consumes more memory and can be slower than primitive data types, leading to unnecessary overhead for small input values.
