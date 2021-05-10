using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class AudioSettings2 : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectsPref";
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource[] backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    void Awake(){
        ContinueSettings();
    }

    private void ContinueSettings(){
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
        // CarAudio.lowPitchMax = soundEffectsFloat;

        for(int i = 0; i < backgroundAudio.Length; i++){
            
            backgroundAudio[i].volume = backgroundFloat;
        }
        for(int i = 0; i < soundEffectsAudio.Length; i++){
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }
}
