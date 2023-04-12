using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManageGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [SerializeField] SpriteRenderer Cube;
    [SerializeField] Text Count0;
    [SerializeField] Text Count1;
    [SerializeField] Text Count2;
    [SerializeField] Text Count3;
    public SpriteRenderer[] Hasiii;
    enum Bunny
    {
        Hase1,
        Hase2,
        Hase3,
        Hase4,
    }

    public void StartGame()
    {
        int ActivePlayer = 0;
        int[] Counts = { 0, 0, 0, 0 };

        switch (Random.Range(0, 6))
        {
            case 0:
                Cube.color = Color.white;
                if (Bunny.Hase1 == Bunny.Hase1)
                {
                    Counts[0]++;
                    Debug.Log("white");
                }
                break;
            case 1:
                Cube.color = Color.yellow;
                if (Bunny.Hase2 == Bunny.Hase2)
                {
                    Counts[1]++;
                    Debug.Log("gelbii");
                }
                break;
            case 2:
                Cube.color = Color.red;
                if (Bunny.Hase3 == Bunny.Hase3)
                {
                    Counts[2]++;
                    Debug.Log("rotiiii");
                }
                break;
            case 3:
                Cube.color = Color.blue;
                if (Bunny.Hase4 == Bunny.Hase4)
                {
                    Counts[3]++;
                    Debug.Log("blauiii");
                }
                break;
            case 4:
                Cube.color = Color.green;
                for (int i = 0; i < 4; i++)
                {
                    Counts[i] += 2;
                    Debug.Log("juhuuuuu grean");
                }
                break;
            case 5:
                Cube.color = Color.black;
                for (int i = 0; i < 4; i++)
                {
                    Counts[i]--;
                    Debug.Log("Mannooooo");
                }
                break;
        }


        if (ActivePlayer >= 10)
        {
            Debug.Log("We have a winner");
        }


    

    }

}
