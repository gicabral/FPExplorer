using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectsPref";
    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource[] backgroundAudio;
    public AudioSource[] soundEffectsAudio;
 
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0){
            backgroundFloat = .25f;
            soundEffectsFloat = .50f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else{
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
        
    }

    public void SaveSoundSettings(){
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsSlider.value);
    }

    void OnApplicationFocus(bool inFocus){
        if(!inFocus){
            SaveSoundSettings();
        }
    }

    public void UpdateSound(){
        for(int i = 0; i < backgroundAudio.Length; i++){
            backgroundAudio[i].volume = backgroundSlider.value;
        }
        for(int i = 0; i < soundEffectsAudio.Length; i++){
            soundEffectsAudio[i].volume = soundEffectsSlider.value;
        }
    }

}
