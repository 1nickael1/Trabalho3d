using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    [SerializeField] ElevatorController ec;

    void Closed()
    {
        ec.Move();
    }
}
