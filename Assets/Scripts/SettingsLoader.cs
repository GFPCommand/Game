using UnityEngine;

public class SettingsLoader : MonoBehaviour
{
    private string _tag = "isLoad";
    private string _settingsTag = "Settings";

    private bool _hasData = false;

    private Settings _settings;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(_tag))
        {
            _hasData = true;
        }

        LoadSettings();
    }

    private void LoadSettings()
    {
        string data;

        if (_hasData)
        {
            data = PlayerPrefs.GetString(_settingsTag);

            _settings = JsonUtility.FromJson<Settings>(data);
        } else
        {
            _settings = new Settings();

            _settings.IsMusicPlay = true;
            _settings.IsSoundPlay = true;

            _settings.MusicVolume = 100f;
            _settings.SoundVolume = 100f;
        }
    }

    private void SaveSettings()
    {
        string data;

        data = JsonUtility.ToJson(_settings);

        PlayerPrefs.SetString(data, _settingsTag);
    }
}
