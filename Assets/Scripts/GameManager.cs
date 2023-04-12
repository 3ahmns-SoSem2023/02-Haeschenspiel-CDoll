using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] SpriteRenderer Cube;
    [SerializeField] Text Count0;
    [SerializeField] Text Count1;
    [SerializeField] Text Count2;
    [SerializeField] Text Count3;
    public Color Weiss;
    public Color Gelb;
    public Color Rot;
    public Color Blau;
    public Color Gruen;
    public Color Schwarz;
    int[] Counts = { 0, 0, 0, 0 };
    public GameObject Ausgangstext;
    public Text WinnerWhite;
    public Button PressMe;

    int ActivePlayer = 0;

    public void PlayGame()
    {
        //while (Counts[0] < 10 && Counts[1] < 10 && Counts[2] < 10 && Counts[3] < 10)
        //{
        switch (Random.Range(0, 6))
        {
            case 0:
                Cube.color = Weiss;
                if (Cube.color == Weiss)
                {
                    Counts[0]++;
                    Debug.Log("hat funkzaniert");
                }
                break;
            case 1:
                Cube.color = Gelb;
                if (Cube.color == Gelb)
                {
                    Counts[1]++;
                }
                break;
            case 2:
                Cube.color = Rot;
                if (Cube.color == Rot)
                {
                    Counts[2]++;
                }
                break;
            case 3:
                Cube.color = Blau;
                if (Cube.color == Blau)
                {
                    Counts[3]++;
                }
                break;
            case 4:
                Cube.color = Gruen;
                for (int i = 0; i < 4; i++)
                {
                    Counts[i] += 2;
                }
                break;
            case 5:
                Cube.color = Schwarz;
                for (int i = 0; i < 4; i++)
                {
                    Counts[i]--;
                }
                break;
        }

        //Debug.Log("Dice: " + Cube.color);

        /*
        Debug.Log("Player0 count: " + Counts[0]);
        Debug.Log("Player1 count: " + Counts[1]);
        Debug.Log("Player2 count: " + Counts[2]);
        Debug.Log("Player3 count: " + Counts[3]);
        */

        Count0.text = Counts[0].ToString();
        Count1.text = Counts[1].ToString();
        Count2.text = Counts[2].ToString();
        Count3.text = Counts[3].ToString();

        //System.Threading.Thread.Sleep(100);
        //if (ActivePlayer >= 3)
        //{
        //    ActivePlayer = 0;
        //    Debug.Log("Next Player: " + ActivePlayer + ", New Round");
        //}
        //else
        //{
        //    ActivePlayer++;
        //    Debug.Log("Next Player: " + ActivePlayer);
        //}
        //}
        
        
        Debug.Log("yippieyay");
        if (Counts[0] >= 10)
        {
            WinnerWhite.text = "White Won The Game :))";
            Ausgangstext.SetActive(true);
            PressMe.interactable = false;
        }
        else if (Counts[1] >= 10)
        {
            WinnerWhite.text = "Yellow Won The Game :))";
            Ausgangstext.SetActive(true);
            PressMe.interactable = false;
        }
        else if (Counts[2] >= 10)
        {
            WinnerWhite.text = "Red Won The Game :))";
            Ausgangstext.SetActive(true);
            PressMe.interactable = false;
        }
        else if (Counts[3] >= 10)
        {
            WinnerWhite.text = "Blue Won The Game :))";
            Ausgangstext.SetActive(true);
            PressMe.interactable = false;
        }
        

            //Debug.Log("Spiel vorbei");

    }
}
