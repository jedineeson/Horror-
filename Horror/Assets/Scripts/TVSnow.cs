using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVSnow : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> m_Images;

    private int m_Index = 0;

    private float m_Timer = 0f;

    [SerializeField]
    private float m_Speed = 0.5f;

    void Update()
    {
        m_Timer++; 

        if (m_Timer > m_Speed)
        {
            for (int i = 0; i < m_Images.Count; i++)
            {
                m_Images[i].SetActive(false);
            }

            m_Images[m_Index].SetActive(true);
            m_Index++;

            if (m_Index > m_Images.Count - 1)
            {
                m_Index = 0;
            }

            m_Timer = 0;
        }
	}
}
