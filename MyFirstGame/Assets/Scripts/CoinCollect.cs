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
    {//oyuncu ile alt�nlar�n �arp��mas� kontrol edilmi�tir
        if(other.tag == "Player")//oyuncu ile alt�n �arp��ma sa�land�ysa
        {
            collectFX.Play();//ses efektini �al
            GlobalCoin.coinCount++;//alt�n say�s� art�r�lm��
            //textScore.GetComponent<Text>().text = "SCORE:" + coinCount;
            this.gameObject.SetActive(false);//toplanan alt�n ekrandan kald�r�lm��t�r
        }
    }
}
