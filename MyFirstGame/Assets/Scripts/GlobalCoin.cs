using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoin : MonoBehaviour
{
    public GameObject textScore;
    public static int coinCount;//toplanan altýnlarý saymak için bir deðiþken oluþturulmuþtur ve diðer scriptlerden eriþebilmek ve her yerde ayný olmasý
                                //için static olaarak tanýmlanmýþtýr

    void Update()
    {
        textScore.GetComponent<Text>().text = "SCORE:" + coinCount;//ekrana toplanan altýn sayýsý yazdýrýlýyor
    }
}
