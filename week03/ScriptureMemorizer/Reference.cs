

public class Reference
{
    public List<Reference> _scriptures = new List<Reference>();
    private string _fileName = "library.txt";
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private Reference _chosenScripture;
    private List<string> _verses = new List<string>();

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;

    }

    public Reference()
    {
        
    }


    public string GetDisplayText()
    {
        
    }
    
    
    
    
    public void LoadScriptures()
    {
        _scriptures.Clear();

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Reference scripture = new Reference();
                scripture._book = parts[0];
                scripture._chapter = int.Parse(parts[1]);
                string[] verseStr = parts[2].Split(",");
                scripture._verse = int.Parse(verseStr[0]);
                if (verseStr.Length == 2)
                {
                    scripture._endVerse = int.Parse(verseStr[1]);
                }
                for (int i = 3; i < parts.Length; i++)
                {
                    scripture._verses.Add(parts[i]);
                }
                _scriptures.Add(scripture);
            }
        }
        else
        {
            Console.WriteLine("File Not Found");
        }
    }

    public Reference ChooseScripture()
    {
        Console.Clear();
        Random randomGenerator = new Random();
        _chosenScripture = _scriptures[randomGenerator.Next(_scriptures.Count)];
        return _chosenScripture;

    }
}