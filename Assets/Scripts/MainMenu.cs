using UnityEngine;

public class MainMenu : Menu
{
    [SerializeField] private Menu _play;
    [SerializeField] private Menu _authors;

    public void OnPlayButtonClicked()
    {
        _play.OnOpenMenuButtonClicked();
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