using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalChoice : MonoBehaviour
{
    public enum AnimalEnum
    {
        Lion,
        Ant,
        Giraff
    }

    private void switchAnimal(AnimalEnum animalia)
    {
        switch (animalia)
        {
            case AnimalEnum.Lion:
                TextLion();
                break;
            case AnimalEnum.Ant:
                TextAnt();
                break;
            case AnimalEnum.Giraff:
                TextGiraff();
                break;
            default:
                Debug.Log("Animal not found");
                break;
        }
    }

    private void TextLion()
    {
        Debug.Log("Lion");
    }

    private void TextAnt()
    {
        Debug.Log("Ant");
    }

    private void TextGiraff()
    {
        Debug.Log("Giraff");
    }

    private void WhichKey()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            switchAnimal(AnimalEnum.Lion);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            switchAnimal(AnimalEnum.Ant);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            switchAnimal(AnimalEnum.Giraff);
        }
    }

    // Update is called once per frame
    void Update()
    {
        WhichKey();
    }
}
