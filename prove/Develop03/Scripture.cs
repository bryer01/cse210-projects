using System;
using System.Collections.Generic;

class Scripture
{
    // Private fields
    private string reference;
    private string text;
    private List<string> words;

    // Constructor for a single verse
    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = new List<string>(text.Split(' '));
    }

    // Constructor for a verse range
    public Scripture(string reference, int startVerse, int endVerse, string[] text)
    {
        this.reference = reference;
        this.text = string.Join(" ", text, startVerse - 1, endVerse - startVerse + 1);

    }

    // Display the complete scripture, including the reference and the text
    public void Display()
    {
        Console.WriteLine("{0}: {1}", reference, text);
    }

    // Hide a random word in the scripture
    public bool HideRandomWord()
    {
        // Find the indices of all non-hidden words
        List<int> nonHiddenIndices = new List<int>();
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].StartsWith("["))
            {
                nonHiddenIndices.Add(i);
            }
        }

        // If there are no non-hidden words, return false
        if (nonHiddenIndices.Count == 0)
        {
            return false;
        }

        // Select a random non-hidden word and replace it with a hidden version
        int randomIndex = nonHiddenIndices[new Random().Next(nonHiddenIndices.Count)];
        words[randomIndex] = "[" + words[randomIndex] + "]";

        return true;
    }
}
