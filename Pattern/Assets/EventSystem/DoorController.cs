using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Quaternion doorOpen;
    private Quaternion doorClosed;

    float speed = 5f;
    float timer = 0f;

    void Start()
    {
        doorOpen = Quaternion.Euler(0, -90, 0);
        doorClosed = transform.rotation;

        //steg 3
        //här subrscribar vi till eventen on open. Gör denna funktionen på eventet onOpen
        TriggerArea.onOpen += OnDoorwayOpen;



        //EXEMPEL
/*        TriggerArea.OnGoal += Fireworks;
        TriggerArea.OnGoal += AudienceSound;
        TriggerArea.OnGoal += AddScore;

        TriggerArea.Victory += Fireworks;
        TriggerArea.Victory += AudienceSound;*/
    }


    //Det här e då funktionen som vi lägger till
    public void OnDoorwayOpen()
    {
        Debug.Log("OpenDoor");
        while(timer < 1f)
        {
            timer += Time.deltaTime / speed;
            transform.rotation = Quaternion.Lerp(doorClosed, doorOpen, timer);
        }
    }
}
