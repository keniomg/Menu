using UnityEngine;
using UnityEngine.Audio;

public class AudioMaster : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    private float _masterVolume;
    private float _musicVolume;
    private float _buttonsVolume;
    private bool _isMuteEnabled;

    private void Update()
    {
        ManageAllSound();
    }

    public void MuteAllSound(bool isEnabled)
    {
        _isMuteEnabled = isEnabled;
    }

    public void ChangeMasterVolume(float volume)
    {
        _masterVolume = volume;
    }

    public void ChangeMusicVolume(float volume)
    {
        _musicVolume = volume;
    }

    public void ChangeButtonsVolume(float volume)
    {
        _buttonsVolume = volume;
    }

    private void ManageAllSound()
    {
        if (_isMuteEnabled)
        {
            _audioMixer.audioMixer.SetFloat("Master Volume", -80);
        }
        else
        {
            ManageMasterVolume();
            ManageMusicVolume();
            ManageButtonsVolume();
        }
    }

    private void ManageMasterVolume()
    {
        _audioMixer.audioMixer.SetFloat("Master Volume", Mathf.Log10(_masterVolume) * 20);
    }

    private void ManageMusicVolume()
    {
        _audioMixer.audioMixer.SetFloat("Music Volume", Mathf.Log10(_musicVolume) * 20);
    }

    private void ManageButtonsVolume()
    {
        _audioMixer.audioMixer.SetFloat("Buttons Volume", Mathf.Log10(_buttonsVolume) * 20);
    }
}