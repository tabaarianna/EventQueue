using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launch : MonoBehaviour
{
    private bool m_IsQuitting;
    public AudioClip aclip;
    private bool m_IsLaunched = false;

    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Launch", Launchd);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Launch", Launchd);
        }
    }
    void Launchd()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            text.text = "Received a launch event : Rocket launching!";
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = aclip;
            audio.Play();

        }
    }
}
