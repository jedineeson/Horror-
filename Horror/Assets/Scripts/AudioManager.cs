using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager m_Instance;
    public static AudioManager Instance
    {
        get
        {
            return m_Instance;
        }
    }

    [SerializeField]
    private AudioSource m_AudioSourceMusic;
    [SerializeField]
    private AudioClip m_LightOnAmbiance;
    [SerializeField]
    private AudioClip m_LightOffAmbiance;

    private bool m_LightOn = true;
    public bool LightOn
    {
        get { return m_LightOn; }
    }

    private void Awake()
    {
        if (m_Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            m_Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {

    }


    /*private void Update()
    {
        Debug.Log(m_AudioSourceMusic.clip);
    }*/


    public void PlayMusic(string aAudioSource)
    {        
        if (aAudioSource == "LightOn")
        {
            if (m_AudioSourceMusic != null)
            {
                m_AudioSourceMusic.Stop();
            }
            m_LightOn = true;
            /*
            if (!m_LightOn)
            {
                if (m_AudioSourceMusic != null)
                {
                    m_AudioSourceMusic.Stop();
                }

                m_AudioSourceMusic.clip = m_LightOnAmbiance;
                m_AudioSourceMusic.Play();
                m_LightOn = true;
            }
            else
            {
                if (m_AudioSourceMusic != null)
                {
                    m_AudioSourceMusic.clip = m_LightOnAmbiance;
                    m_AudioSourceMusic.Play();
                    m_LightOn = true;
                }
            }
            */
        }
        else if (aAudioSource == "LightOff")
        {
            if (m_LightOn)
            {
                if (m_AudioSourceMusic != null)
                {
                    m_AudioSourceMusic.Stop();
                }

                m_AudioSourceMusic.clip = m_LightOffAmbiance;
                m_AudioSourceMusic.Play();
                m_LightOn = false;
            }
            /*else
            {
                if (m_AudioSourceMusic != null)
                {
                    m_AudioSourceMusic.clip = m_LightOffAmbiance;
                    m_AudioSourceMusic.Play();
                    m_LightOn = false;
                }
            }*/
        }
    }

    public void StopMusic()
    {
        if (m_AudioSourceMusic != null)
        {
            m_AudioSourceMusic.Stop();
        }
    }

    public void PlaySFX(AudioClip aClip, Vector3 aPosition)
    {
        
    }
}



