
using System.Runtime.InteropServices;

public class Scripture
{
    public List<Scripture> _scriptures = new List<Scripture>();
    private string _fileName = "library.txt";
    private string _book;
    private string _chapter;
    private string _verseNum;
    private Scripture _chosenScripture;
    private List<string> _verses = new List<string>();



    public void LoadScriptures()
    {
        _scriptures.Clear();

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Scripture scripture = new Scripture();
                scripture._book = parts[0];
                scripture._chapter = parts[1];
                scripture._verseNum = parts[2];
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

    public Scripture ChooseScripture()
    {
        Random randomGenerator = new Random();
        _chosenScripture = _scriptures[randomGenerator.Next(_scriptures.Count)];
        return _chosenScripture;

    }
}