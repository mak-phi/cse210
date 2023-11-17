using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");
        foreach (string term in words)
        {
            Word word = new Word(term);
            _words.Add(word);   
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        int randomIndexToHide = numberToHide;
        if (!_words[randomIndexToHide].IsHidden())
        {
            _words[randomIndexToHide].Hide();
        }
        // Generate new random index to pass to method if word already hidden
        else
        {
            List<int>VisibleWordsIndices = new List<int>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    int index = _words.IndexOf(word);
                    VisibleWordsIndices.Add(index);
                }
            }
            if (VisibleWordsIndices.Count > 0)
            {
                randomIndexToHide = VisibleWordsIndices[new Random().Next(VisibleWordsIndices.Count)];
                HideRandomWords(randomIndexToHide);
            }
            // Catch index out of range error
            else
            {
                IsCompletelyHidden();
            }       
        }

    }
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }
        
        return _reference.GetDisplayText() + displayText;
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;

    }
    public int CountWords()
    {
        return _words.Count;
    }
}