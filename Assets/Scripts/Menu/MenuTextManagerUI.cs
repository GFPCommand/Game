using UnityEngine;
using TMPro;

public class MenuTextManagerUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textAuthors;

    private MenuTextManager _manager;

    private string _localeFolder;

    private string _text;

    private void Awake()
    {
        _localeFolder = Application.dataPath + "\\Locale\\";

        _manager = new MenuTextManager(_localeFolder);

        _manager.ReadAuthorsFromFile();

        _text = _manager.GetText();
    }

    private void Update()
    {
        _textAuthors.text = _text;
    }
}