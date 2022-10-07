using System.Collections;
using System.Globalization;
using UnityEngine;
using TMPro;

public class DialogManagerUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textDialog;

    private DialogManager _manager;

    private static string _localeFolder, _file;

    [SerializeField]
    public static int DialogNumber;

    private string _text;

    private void Awake()
    {
        _localeFolder = Application.dataPath + "\\Locale\\";

        _manager = new DialogManager(_localeFolder);

        _file = "OrphanageText.txt";
    }

    private void Start()
    {
        StartCoroutine(ReadText());
    }

    IEnumerator ReadText()
    {
        while (true)
        {
            _manager.ReadDialogFromFile(_file, DialogNumber);

            _text = _manager.GetText();

            _textDialog.text = _text;

            yield return new WaitForSeconds(0.001f);
        }
    }
}