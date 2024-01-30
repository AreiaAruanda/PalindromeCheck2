using System;
using System.ComponentModel.Design;
using System.Text;

Console.Write("Please enter a word or sentence: ");
string word = Console.ReadLine();
string wordNew = word.ToLower();

string[] charactersToRemove = { " ", ".", "!", "?", ":", ";" };
wordNew = string.Concat(wordNew.Split(charactersToRemove, StringSplitOptions.RemoveEmptyEntries));


bool palindromecheck = false;

for (int i = 0; i < wordNew.Length; i++)
{
    if (wordNew[i] != wordNew[wordNew.Length - 1 - i])
    {
        palindromecheck = false;
        break;
    }
    else if (wordNew[i] == wordNew[wordNew.Length - 1 - i])
    {
        palindromecheck = true;
    }
}

if (palindromecheck)
{
    Console.WriteLine($"'{word}' is a palindrome.");
}
else if (!palindromecheck)
{
    Console.WriteLine($"'{word}' is not a palindrome.");
}


