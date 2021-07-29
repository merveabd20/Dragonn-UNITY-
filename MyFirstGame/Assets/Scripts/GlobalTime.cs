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
        if (seconds == 0)//zaman bitti�inde olacaklar
        {
            player.GetComponent<PlayerControls>().enabled = false;//oyuncuyu pasif hale getir
            seconds = 0;
            timeUpText.SetActive(true);//zaman bittti�ini s�yleyen texti g�ster
            fadeOut.SetActive(true);//animasyonu �al��t�r
            StartCoroutine(RespawningLevel());//yeniden do�ma i�lemini �al��t�r
        }
        else
        {
            if (deductingTime == false)
            {
                deductingTime = true;//de�i�kenin de�erini true yap
                StartCoroutine(DeductSecond());//methoda git
            }
        }
    }
    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);//1s bekle
        seconds--;//saniyeyi bir azalt
        timeDisplay.GetComponent<Text>().text = "TIME:" + seconds;//saniyeyi ekrana yaz
        deductingTime = false;//de�i�kenin de�erini false yap
    }
    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3); //3s bekle
        SceneManager.LoadScene(3);//3. screeni y�kle
    }
}
