using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    [SerializeField] Animator       el;
    [SerializeField] Animator       door3;
    [SerializeField] Animator       door4;
    [SerializeField] BoxCollider    button;

    bool goUp = true;

    public void CloseDoors()
    {
        button.enabled = false;

        door3.Play("Door_3_Closing");
        door4.Play("Door_4_Closing");
    }

    public void Move()
    {
        if (goUp)
        {
            el.Play("Elevator_Going_Up");
            goUp = false;
        }
        else
        {
            el.Play("Elevator_Going_Down");
            goUp = true;
        }
    }

    public void OpenDoors()
    {
        door3.Play("Door_3_Opening");
        door4.Play("Door_4_Opening");

        button.enabled = true;
    }
}
