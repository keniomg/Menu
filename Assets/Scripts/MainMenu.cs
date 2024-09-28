using UnityEngine;

public class MainMenu : Menu
{
    [SerializeField] private Menu _play;
    [SerializeField] private Menu _authors;
    [SerializeField] private Menu _soundSettings;

    public void OnSoundButtonClicked()
    {
        _play.OnOpenMenuButtonClicked();
    }

    public void OnPlayButtonClicked()
    {
        _soundSettings.OnOpenMenuButtonClicked();
    }

    public void OnAuthorsButtonClicked()
    {
        _authors.OnOpenMenuButtonClicked();
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}