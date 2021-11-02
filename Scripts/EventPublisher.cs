using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            EventBus.TriggerEvent("Bounce");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            EventBus.TriggerEvent("Eject");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            EventBus.TriggerEvent("Throw");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            EventBus.TriggerEvent("Shoot");
        }
    }
}
