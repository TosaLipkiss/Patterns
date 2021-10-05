using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ApaInfo apaInfo;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            //Skapar object Apa med information från scriptableObjects (name, health)
            GameObject apaObject = new GameObject();

            Apa apa = apaObject.AddComponent<Apa>();
            apa.name = apaInfo.names[Random.Range(0,3)];
            apa.health = apaInfo.startHealth;
        }
    }
}
