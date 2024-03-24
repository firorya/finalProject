using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioMixer mixer;

    public Slider masterSlider;
    public Slider sesSlider;
    public Slider musicSlider;

    void SetSliders()
    {
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume");
        sesSlider.value = PlayerPrefs.GetFloat("sesVolume");
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            mixer.SetFloat("masterVolume", PlayerPrefs.GetFloat("masterVolume"));
            mixer.SetFloat("sesVolume", PlayerPrefs.GetFloat("sesVolume"));
            mixer.SetFloat("musicVolume", PlayerPrefs.GetFloat("musicVolume"));

            SetSliders();
        }
        else
        {
            SetSliders();
        }
    }

    public void UpdateMasterVolume()
    {
        mixer.SetFloat("masterVolume", masterSlider.value);
        PlayerPrefs.SetFloat("masterVolume", masterSlider.value);
    }
    public void UpdateMusicVolume()
    {
        mixer.SetFloat("musicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }
    public void UpdateSesVolume()
    {
        mixer.SetFloat("sesVolume", sesSlider.value);
        PlayerPrefs.SetFloat("sesVolume", sesSlider.value);
    }

    
}
