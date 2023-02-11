using System;
using System.Collections.Generic;


class Scripture
{

    private Reference _ref;
    private List<Word> _words;

    public Scripture(Reference _ref, string text)
    {
        this._ref = _ref;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int count)
    {
        int i = 0;
        while (i < _words.Count && count > 0)
        {
            _words[i].Hide();
            i++;
            count--;
        }
    }

    public bool IsCompletelyHidden()

    {
        foreach (var word in _words)
        {
            //if (!word._isHidden)
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine(_ref.GetDisplay());
        Console.WriteLine(string.Join(" ", _words));
    }
}