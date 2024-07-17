// See https://aka.ms/new-console-template for more information
/*int x = 121;
int rev = 0;

while (x != 0)
{
    
    int Dig = x % 10;
 

    rev = rev * 10 + Dig;
    x = x / 10;

}
Console.WriteLine(rev);
Console.ReadLine();*/
public class Solution
{
    public bool IsPalindrome(int x)
    {
        int reverseNum = 0;
        int Actual = x;
        while (x != 0)
        {
            int lastDigit = x % 10;
            reverseNum = reverseNum * 10 + lastDigit;
            x = x / 10;
        }

        if (Actual == reverseNum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

   public static void Main(String[] args)
    {
        Solution solution = new Solution();
        bool result = solution.IsPalindrome(123);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}