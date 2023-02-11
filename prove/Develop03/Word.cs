using System;
using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplay()
    {
        return _isHidden ? "_" : _text;
    }
}