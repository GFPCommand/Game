using UnityEngine;

public class MenuUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _authorsObj, _optionsObj, _playsObj;

    public void PlayButton()
    {
        _playsObj.SetActive(true);
        _optionsObj.SetActive(false);
        _authorsObj.SetActive(false);
    }

    public void OpenOptions()
    {
        _optionsObj.SetActive(true);
        _playsObj.SetActive(false);
        _authorsObj.SetActive(false);
    }

    public void OpenAuthors()
    {
        _authorsObj.SetActive(true);
        _playsObj.SetActive(false);
        _optionsObj.SetActive(false);   
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
