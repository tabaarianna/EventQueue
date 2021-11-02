using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eject : MonoBehaviour
{
    private bool m_IsQuitting;
    public AudioClip aclip;

    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Eject", Ejectd);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Eject", Ejectd);
        }
    }
    void Ejectd()
    {
        text.text = "Received an eject event : Ejecting Rocket!";
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = aclip;
        audio.Play();
    }
}
