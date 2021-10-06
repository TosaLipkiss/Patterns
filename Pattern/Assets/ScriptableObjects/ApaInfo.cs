using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ApaInfo", order = 1)]
public class ApaInfo : ScriptableObject
{
    public string[] animalSpecies;
    public string[] maleNames;
    public string[] femaleNames;
    public string[] genders;
    public int age;
    public string sprite;
}
