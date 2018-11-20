using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{
    [SerializeField]
    private GameObject m_LightOnObjs;
    [SerializeField]
    private GameObject m_LightOffObjs;

    [SerializeField]
    private bool m_LightIsOn = true;
    public bool LightIsOn
    {
        get { return m_LightIsOn; }
        set { LightIsOn = value; }
    }

    private void Start()
    {
        SetSceneObjs();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_LightIsOn = !m_LightIsOn;
            SetSceneObjs();
        }
    }

    private void SetSceneObjs()
    {
        if(m_LightIsOn)
        {
            AudioManager.Instance.PlayMusic("LightOn");
            m_LightOnObjs.SetActive(true);
            m_LightOffObjs.SetActive(false);
        }
        else
        {
            AudioManager.Instance.PlayMusic("LightOff");
            m_LightOnObjs.SetActive(false);
            m_LightOffObjs.SetActive(true);
        }
    }

    protected override void Interaction()
    {
        m_LightIsOn = !m_LightIsOn;
        SetSceneObjs();
    }
}
