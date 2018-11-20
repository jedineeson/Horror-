using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXAudio : MonoBehaviour
{ 
    [SerializeField]
    private AudioSource m_AudioSource;

    private float m_Counter = 0f;
    private float m_Duration = 2f;

    public void Setup(AudioClip i_Clip)
    {
        m_AudioSource.clip = i_Clip;
        m_Duration = i_Clip.length;
    }

    public void Play()
    {
        m_AudioSource.Play();
    }
}


