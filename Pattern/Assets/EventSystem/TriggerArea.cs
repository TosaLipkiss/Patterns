using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//deklarer en funktion som tar in noll parametrar
//Delegate �r instruktioner
public delegate void OpenDoorway();

public class TriggerArea : MonoBehaviour
{
    //deklarerar event
    public static event OpenDoorway onOpen;

    private void OnTriggerEnter(Collider other)
    {
        //Game event har en instans variabel som har har en funktion som heter detta
        //steg 1
        onOpen?.Invoke();


        //N�r man g�r in i triggerns collider, k�rs denna funktion
        // GameEvent.Instance.DoorwayTriggerEnter();
    }
}
