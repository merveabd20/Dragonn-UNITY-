using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawning : MonoBehaviour
{
    void Start()
    {//yeniden do�ma i�lemi
        Time.timeScale = 1;//zaman� ba�lat
        GlobalCoin.coinCount = 0;//alt�nlar� s�f�rla
        SceneManager.LoadScene(GlobalLevel.levelNumber);//di�er seviyeye git
    }
}
