public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        // No value assigned to _endVerse by default: to be used in condition statement
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}{(_endVerse > 0 ? -_endVerse : "")}";
    }
}


// Possible getters and setters