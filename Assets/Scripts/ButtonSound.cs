using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource _clip;

    public void OnButtonClicked()
    {
        _clip.Play();
    }
}