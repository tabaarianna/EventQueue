using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    private bool m_IsQuitting;
    public AudioClip aclip;

    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Shoot", Shootd);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Shoot", Shootd);
        }
    }
    void Shootd()
    {
        text.text = "Received a shoot event : Shoot!";
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = aclip;
        audio.Play();
    }
}
