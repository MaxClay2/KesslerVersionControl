using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    //Refrences the Audio Mixer
    public AudioMixer audioMixer;


    //Sets the volumemixer for the master game volume 
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);

    }

    //sets the Quality of the game to the setting chosen in the dropdown 
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }






}
