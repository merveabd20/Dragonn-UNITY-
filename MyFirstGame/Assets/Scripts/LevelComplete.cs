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
        if(importedCoins == 4)//bir seviyedeki t�m alt�nlar topland� m�
        {
            StartCoroutine(LevelCompleted());//methoda git
        }
    }
    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(0.2f);//0.2s bekle
        completedText.SetActive(true);//seviyenin tamamland���n� s�yleyen texti g�ster
        fadeOut.SetActive(true);//animasyonu �al��t�r
        player.GetComponent<PlayerControls>().enabled = false;//oyuncuyu pasif hale getir
        yield return new WaitForSeconds(3);//3s bekle
        GlobalLevel.levelNumber++;//level seviyesini art�r
        PlayerPrefs.SetInt("LevelLoadNum",GlobalLevel.levelNumber);//seviyeyi kaydet
        SceneManager.LoadScene(2);//2.sahneyi y�kle
        Time.timeScale = 0;//zaman� durdur
    }
}
