using System;
using System.Collections.Generic;
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetDisplay()
    {
        return _endVerse == null ?
            $"{_book} {_chapter}:{_startVerse}" :
            $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}