using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public delegate void OpenDoorway();

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;

    private void Awake()
    {
        current = this;
    }


    //de här e event
    public event OpenDoorway onOpen;

    public void DoorwayTriggerEnter()
    {
        onOpen?.Invoke();
    }
}
