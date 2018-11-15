using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject m_LightOnObjs;

    [SerializeField]
    private GameObject m_LightOffObjs;

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
        }
        else
        {
            m_LightOnObjs.SetActive(false);
            m_LightOffObjs.SetActive(true);
        }
    }
}
