using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{
    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject timeUpText;
    public GameObject fadeOut;
    public GameObject player;
    void Update()
    {
        if (seconds == 0)//zaman bittiðinde olacaklar
        {
            player.GetComponent<PlayerControls>().enabled = false;//oyuncuyu pasif hale getir
            seconds = 0;
            timeUpText.SetActive(true);//zaman bitttiðini söyleyen texti göster
            fadeOut.SetActive(true);//animasyonu çalýþtýr
            StartCoroutine(RespawningLevel());//yeniden doðma iþlemini çalýþtýr
        }
        else
        {
            if (deductingTime == false)
            {
                deductingTime = true;//deðiþkenin deðerini true yap
                StartCoroutine(DeductSecond());//methoda git
            }
        }
    }
    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);//1s bekle
        seconds--;//saniyeyi bir azalt
        timeDisplay.GetComponent<Text>().text = "TIME:" + seconds;//saniyeyi ekrana yaz
        deductingTime = false;//deðiþkenin deðerini false yap
    }
    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3); //3s bekle
        SceneManager.LoadScene(3);//3. screeni yükle
    }
}
