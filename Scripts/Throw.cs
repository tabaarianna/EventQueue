using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throw : MonoBehaviour
{
    private bool m_IsQuitting;
    public AudioClip aclip;

    public Text text;
    void OnEnable()
    {
        EventBus.StartListening("Throw", Throwd);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Throw", Throwd);
        }
    }
    void Throwd()
    {
        text.text = "Received a Throw event : Throw ball!";
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = aclip;
        audio.Play();
    }
}
