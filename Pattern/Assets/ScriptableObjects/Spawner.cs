using UnityEngine;

public class Spawner : MonoBehaviour
{
    public AnimalInfo apaInfo;
    public AnimalInfo tigerInfo;
    public AnimalInfo zebraInfo;

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
            //0 Spawn Tiger
            case 0:
                {
                    GameObject tigerObject = new GameObject();
                    Tiger tiger = tigerObject.AddComponent<Tiger>();

                    if (randomGender == 0)
                    {
                        tiger.gender = tigerInfo.genders[randomGender];
                        tiger.name = tigerInfo.maleNames[Random.Range(0, 5)];
                    }

                    else if (randomGender == 1)
                    {
                        tiger.gender = tigerInfo.genders[randomGender];
                        tiger.name = tigerInfo.femaleNames[Random.Range(0, 5)];
                    }

                    SpriteRenderer spriteRenderer = tiger.gameObject.AddComponent<SpriteRenderer>();
                    tiger.sprite = tigerInfo.sprite;
                    spriteRenderer.sprite = tiger.sprite;

                    tiger.species = tigerInfo.animalSpecies;
                    tiger.maxAge = tigerInfo.maxAge;
                    tiger.age = tigerInfo.startAge;
                    break;
                }

            //1 Spawn zebra
            case 1:
                {
                    GameObject zebraObject = new GameObject();
                    Zebra zebra = zebraObject.AddComponent<Zebra>();

                    zebra.species = zebraInfo.animalSpecies;

                    if (randomGender == 0)
                    {
                        zebra.gender = zebraInfo.genders[randomGender];
                        zebra.name = zebraInfo.maleNames[Random.Range(0, 5)];
                    }

                    else if (randomGender == 1)
                    {
                        zebra.gender = zebraInfo.genders[randomGender];
                        zebra.name = zebraInfo.femaleNames[Random.Range(0, 5)];
                    }

                    SpriteRenderer spriteRenderer = zebra.gameObject.AddComponent<SpriteRenderer>();
                    zebra.sprite = zebraInfo.sprite;
                    spriteRenderer.sprite = zebra.sprite;

                    zebra.maxAge = zebraInfo.maxAge;
                    zebra.age = zebraInfo.startAge;
                    break;
                }

            //2 Spawn apa
            case 2:
                {
                    GameObject apaObject = new GameObject();
                    Apa apa = apaObject.AddComponent<Apa>();

                    apa.species = apaInfo.animalSpecies;

                    if (randomGender == 0)
                    {
                        apa.gender = apaInfo.genders[randomGender];
                        apa.name = apaInfo.maleNames[Random.Range(0, 5)];
                    }

                    else if (randomGender == 1)
                    {
                        apa.gender = apaInfo.genders[randomGender];
                        apa.name = apaInfo.femaleNames[Random.Range(0, 5)];
                    }

                    SpriteRenderer spriteRenderer = apa.gameObject.AddComponent<SpriteRenderer>();
                    apa.sprite = apaInfo.sprite;
                    spriteRenderer.sprite = apa.sprite;

                    apa.maxAge = apaInfo.maxAge;
                    apa.age = apaInfo.startAge;
                    break;
                }

            default:
                {
                    break;
                }

        }
    }
}
