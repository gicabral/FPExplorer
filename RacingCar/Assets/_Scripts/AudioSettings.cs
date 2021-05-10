using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume){
        audioMixer.SetFloat("Volume", volume);
    }
    // private static readonly string FirstPlay = "FirstPlay";
    // private int firstPlayInt;

    // public AudioSource m_MyAudioSource;
    // public Slider backgroundSlider, SFSlider;
    // private float Slider backgroundFloat, SFFloat;
    // //Value from the slider, and it converts to volume level
    // float m_MySliderValue;

    // void Start()
    // {
    //     firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
    //     if (firstPlayInt == 0)
    //     {

    //     }
    //     else{

    //     }
    // }

    // void Update()
    // {
    //     m_MySliderValue = m_MySlider.GetComponent<Slider>().value;
    //     m_MyAudioSource = m_MyAudioSource.GetComponent<AudioSource>();
    //     m_MyAudioSource.volume = m_MySliderValue;
    // }
}
