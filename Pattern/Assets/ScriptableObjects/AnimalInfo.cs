using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AnimalInfo", order = 1)]
public class AnimalInfo : ScriptableObject
{
    public string[] animals;
    public string[] maleNames;
    public string[] femaleNames;
    public string[] genders;
    public int startAge;
    public string sprite;
}
