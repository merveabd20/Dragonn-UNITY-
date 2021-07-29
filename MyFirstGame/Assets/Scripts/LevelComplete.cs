using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    public int importedCoins;
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;

    void Update()
    {
        importedCoins = GlobalCoin.coinCount;
        if(importedCoins == 4)//bir seviyedeki tüm altýnlar toplandý mý
        {
            StartCoroutine(LevelCompleted());//methoda git
        }
    }
    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(0.2f);//0.2s bekle
        completedText.SetActive(true);//seviyenin tamamlandýðýný söyleyen texti göster
        fadeOut.SetActive(true);//animasyonu çalýþtýr
        player.GetComponent<PlayerControls>().enabled = false;//oyuncuyu pasif hale getir
        yield return new WaitForSeconds(3);//3s bekle
        GlobalLevel.levelNumber++;//level seviyesini artýr
        PlayerPrefs.SetInt("LevelLoadNum",GlobalLevel.levelNumber);//seviyeyi kaydet
        SceneManager.LoadScene(2);//2.sahneyi yükle
        Time.timeScale = 0;//zamaný durdur
    }
}
