using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField]
    private Transform m_CloseTrans;
    [SerializeField]
    private Transform m_OpenTrans;

    [SerializeField]
    private float m_MotionDuration = 5f;

    private float m_MotionProgression = 0f;

    private bool m_IsOpen = false;

    private bool m_InMotion = false;

    private void Update()
    {
        if(m_InMotion)
        {
            DoorMotion();
        }
    }

    private void DoorMotion()
    {
        m_MotionProgression += Time.deltaTime;
        
        if (m_IsOpen)
        {
            gameObject.transform.rotation = Quaternion.Slerp(m_OpenTrans.rotation, m_CloseTrans.rotation, m_MotionProgression/m_MotionDuration);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Slerp(m_CloseTrans.rotation, m_OpenTrans.rotation, m_MotionProgression/m_MotionDuration);
        }

        if (m_MotionProgression >= m_MotionDuration)
        {
            m_InMotion = !m_InMotion;
            m_IsOpen = !m_IsOpen;
            m_MotionProgression = 0;
        }
    }

    protected override void Interaction()
    {
        m_InMotion = true;
    }
}
