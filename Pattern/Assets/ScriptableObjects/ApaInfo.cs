using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ApaInfo", order = 1)]
public class ApaInfo : ScriptableObject
{
    public int startHealth;
    public string[] names;
}
