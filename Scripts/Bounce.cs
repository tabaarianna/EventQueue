using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounce : MonoBehaviour
{
    private bool m_IsQuitting;
    public AudioClip aclip;
    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Bounce", Bounced);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Bounce", Bounced);
        }
    }
    void Bounced()
    {
        text.text = "Received a bounce event : Bounce ball";
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = aclip;
        audio.Play();

    }
}
