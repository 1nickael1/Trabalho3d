using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCol : MonoBehaviour
{
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool>{}
    public BoolEvent CanPressButtonEvent;

    void Awake()
    {
        if (CanPressButtonEvent == null)
            CanPressButtonEvent = new BoolEvent();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == 8)
            CanPressButtonEvent.Invoke(true);
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.layer == 8)
            CanPressButtonEvent.Invoke(false);
    }
}
