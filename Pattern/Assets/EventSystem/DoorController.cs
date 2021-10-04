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

        GameEvent.current.onOpen += OnDoorwayOpen;
    }

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
