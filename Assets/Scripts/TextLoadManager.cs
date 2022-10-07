using System.Globalization;

public abstract class TextLoadManager
{
    protected string Path, ResultPath;

    protected string CheckLocaleFolder()
    {
        return Path + SetCurrentCultureName() + "\\";
    }

    protected string SetCurrentCultureName() => 
        CultureInfo.CurrentCulture.Name == "ru-RU" ? "ru-RU" : "en-EN";

    public abstract string GetText();
}