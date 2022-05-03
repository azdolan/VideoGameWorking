using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer mixer;
    
    public void SetVolume(float volume)
    {
        Debug.Log("Changing Volume to: " + volume);
        mixer.SetFloat("volume", volume);
    }    
}
