using UnityEngine;

public class Spawner : MonoBehaviour
{
    public AnimalInfo animalaInfo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Skapar object Apa med information från scriptableObjects (name, health)
            int randomAnimal = Random.Range(0, 3);
            int randomGender = Random.Range(0, 2);

            Animal(randomAnimal, randomGender);
        }
    }

    public void Animal(int randomNumber, int randomGender)
    {
        switch (randomNumber)
        {
            case 0:
                {
                    GameObject apaObject = new GameObject();
                    Tiger tiger = apaObject.AddComponent<Tiger>();

                    tiger.animal = animalaInfo.animals[0];

                    if (randomGender == 0)
                    {
                        tiger.gender = animalaInfo.genders[randomGender];
                        tiger.name = animalaInfo.maleNames[Random.Range(0, 3)];
                    }

                    else if (randomGender == 1)
                    {
                        tiger.gender = animalaInfo.genders[randomGender];
                        tiger.name = animalaInfo.femaleNames[Random.Range(0, 3)];
                    }

                    tiger.age = animalaInfo.startAge;
                    break;
                }

            case 1:
                {
                    GameObject apaObject = new GameObject();
                    Zebra zebra = apaObject.AddComponent<Zebra>();

                    zebra.animal = animalaInfo.animals[1];

                    if (randomGender == 0)
                    {
                        zebra.gender = animalaInfo.genders[randomGender];
                        zebra.name = animalaInfo.maleNames[Random.Range(0, 3)];
                    }

                    else if (randomGender == 1)
                    {
                        zebra.gender = animalaInfo.genders[randomGender];
                        zebra.name = animalaInfo.femaleNames[Random.Range(0, 3)];
                    }

                    zebra.age = animalaInfo.startAge;
                    break;
                }

            case 2:
                {
                    GameObject apaObject = new GameObject();
                    Apa apa = apaObject.AddComponent<Apa>();

                    apa.animal = animalaInfo.animals[2];

                    if (randomGender == 0)
                    {
                        apa.gender = animalaInfo.genders[randomGender];
                        apa.name = animalaInfo.maleNames[Random.Range(0, 3)];
                    }

                    else if (randomGender == 1)
                    {
                        apa.gender = animalaInfo.genders[randomGender];
                        apa.name = animalaInfo.femaleNames[Random.Range(0, 3)];
                    }

                    apa.age = animalaInfo.startAge;
                    break;
                }

            default:
                {
                    break;
                }

        }
    }
}
