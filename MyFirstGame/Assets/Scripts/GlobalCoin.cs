using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoin : MonoBehaviour
{
    public GameObject textScore;
    public static int coinCount;//toplanan alt�nlar� saymak i�in bir de�i�ken olu�turulmu�tur ve di�er scriptlerden eri�ebilmek ve her yerde ayn� olmas�
                                //i�in static olaarak tan�mlanm��t�r

    void Update()
    {
        textScore.GetComponent<Text>().text = "SCORE:" + coinCount;//ekrana toplanan alt�n say�s� yazd�r�l�yor
    }
}
