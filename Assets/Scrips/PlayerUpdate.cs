using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerUpdate : MonoBehaviour
{
    bool canPressBt = false;

    public UnityEvent OnPressEvent;

    void Awake()
    {
        if (OnPressEvent == null)
            OnPressEvent = new UnityEvent();
    }

    void Update()
    {
        if (canPressBt && Input.GetMouseButtonDown(0))
            OnPressEvent.Invoke();
    }

    public void SetCanPressButton(bool b)
    {
        canPressBt = b;
    }
}
