

using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Scripture
{
    private string _referenceText;
    private int _firstVerseCount = 0;
    private int _secondVerseCount = 0;
    private List<Word> _words = new List<Word>();

    public Scripture(string referenceText, List<string> chosenVerses)
    {

        _referenceText = referenceText;;
        foreach (string verse in chosenVerses)
        {
            string[] verseWords = verse.Split(' ');
            foreach (string word in verseWords)
            {
                Word w = new Word(word);
                _words.Add(w);
                if (verse == chosenVerses[0])
                {
                    _firstVerseCount += 1;
                }
                else
                {
                    _secondVerseCount += 1;
                }
            }
        }


    }

    public Scripture()
    {
        
    }


    public void HideRandomWords()
{
    Random rand = new Random();

    int hiddenThisCall = 0;

    while (hiddenThisCall < (_words.Count / 4) && !IsCompletelyHidden())
    {
        int index = rand.Next(_words.Count);

        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenThisCall++;
        }
    }
}

    public string GetFullDisplayText()
    {
        string scriptureText = "";
        int wordCounter = _firstVerseCount;
        foreach (Word w in _words)
        {
            if (wordCounter > 0)
            {
                scriptureText += $"{w.GetDisplayText()} ";
                wordCounter--;
                if (wordCounter == 0)
                {
                    scriptureText += "\n";
                }
            }
            else
            {
                scriptureText += $"{w.GetDisplayText()} ";
            }
        }

        return $"{_referenceText}\n{scriptureText}\n";
    }

    public bool IsCompletelyHidden()
    {
        
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }

        return true;

    }
}