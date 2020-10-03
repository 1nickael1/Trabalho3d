using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    public bool IsActive = false;
    void OnTriggerEnter(Collider other)
    {
        IsActive = true;
    }

    void OnTriggerExit(Collider other)
    {
        IsActive = false;
    }
}
