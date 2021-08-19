using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer _audioMixer;
    public string _channel;

    public void SetMaster(float sliderValue)
    {
        _audioMixer.SetFloat(_channel, Mathf.Log10(sliderValue) * 20);
    }
}
