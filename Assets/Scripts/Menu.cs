using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OnOpenMenuButtonClicked()
    {
        gameObject.SetActive(true);
    }

    public void OnCloseMenuButtonClicked()
    {
        gameObject.SetActive(false);
    }
}