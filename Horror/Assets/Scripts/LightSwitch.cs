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
    private List<Light> m_Lights;

    [SerializeField]
    private bool m_LightIsOn = true;

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
            m_LightOnObjs.SetActive(true);
            m_LightOffObjs.SetActive(false);
            for(int i = 0; i < m_Lights.Count; i++)
            {
                m_Lights[i].enabled = true;
            }
        }
        else
        {
            m_LightOnObjs.SetActive(false);
            m_LightOffObjs.SetActive(true);
            for (int i = 0; i < m_Lights.Count; i++)
            {
                m_Lights[i].enabled = false;
            }
        }
    }

    protected override void Interaction()
    {
        m_LightIsOn = !m_LightIsOn;
        SetSceneObjs();
    }
}
