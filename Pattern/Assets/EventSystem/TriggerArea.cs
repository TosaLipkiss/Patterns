using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//deklarer en funktion som tar in noll parametrar
//Delegate är instruktioner
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


        //När man går in i triggerns collider, körs denna funktion
        // GameEvent.Instance.DoorwayTriggerEnter();
    }
}
