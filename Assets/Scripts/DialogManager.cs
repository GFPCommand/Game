using System.IO;

public class DialogManager : TextLoadManager
{
    private string _dialog;

    public DialogManager(string path)
    {
        Path = path;
    }

    public void ReadDialogFromFile(string openFile, int number)
    {
        ResultPath = CheckLocaleFolder() + openFile;
        using (StreamReader file = new StreamReader(ResultPath))
        {
            for (int i = -1; i < number; i++)
            {
                _dialog =  file.ReadLine();
            }
        }
    }

    public override string GetText()
    {
        return _dialog;
    }
}