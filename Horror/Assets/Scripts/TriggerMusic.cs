using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    [SerializeField]
    private LightSwitch m_LightSwitch;

    private void OnTriggerEnter(Collider aOther)
    {
        if(aOther.tag == "Player")
        {
            if(m_LightSwitch == null)
            {
                AudioManager.Instance.PlayMusic("LightOn");
            }
            else if(m_LightSwitch.LightIsOn)
            {
                AudioManager.Instance.PlayMusic("LightOn");
            }
            else
            {
                AudioManager.Instance.PlayMusic("LightOff");
            }
        }
    }
}
