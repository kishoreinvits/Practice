// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

string[] array = new string[10];
var ascArr = array.Order();

#region IsPalindrome
Console.WriteLine(IsPalindrome("abbabba"));
Console.WriteLine(IsPalindrome("abbabbawow"));
bool IsPalindrome(string str)
{
    var len = str.Length;
    var halfway = len / 2;
    for (int i = 0; i < halfway; i++)
    {
        if (str[i] != str[len - i - 1])
        {
            return false;
        }
    }
    return true;
    // return str.SequenceEqual(str.Reverse());
}
#endregion

Console.ReadKey();