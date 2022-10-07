using System.IO;

public class MenuTextManager : TextLoadManager
{
    private string _authors;

    public MenuTextManager(string path)
    {
        Path = path;
    }

    public void ReadAuthorsFromFile()
    {
        ResultPath = CheckLocaleFolder() + "authors.txt";
        using (StreamReader file = new StreamReader(ResultPath))
        {
            _authors = file.ReadToEnd();
        }
    }

    public override string GetText()
    {
        return _authors;
    }
}