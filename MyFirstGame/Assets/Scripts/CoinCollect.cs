using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class CoinCollect : MonoBehaviour
{
    /*public GameObject textScore;
    public static int coinCount;*/
    public AudioSource collectFX;
    private void OnTriggerEnter(Collider other)
    {//oyuncu ile altýnlarýn çarpýþmasý kontrol edilmiþtir
        if(other.tag == "Player")//oyuncu ile altýn çarpýþma saðlandýysa
        {
            collectFX.Play();//ses efektini çal
            GlobalCoin.coinCount++;//altýn sayýsý artýrýlmýþ
            //textScore.GetComponent<Text>().text = "SCORE:" + coinCount;
            this.gameObject.SetActive(false);//toplanan altýn ekrandan kaldýrýlmýþtýr
        }
    }
}
