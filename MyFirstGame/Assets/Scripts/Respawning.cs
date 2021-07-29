using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawning : MonoBehaviour
{
    void Start()
    {//yeniden doðma iþlemi
        Time.timeScale = 1;//zamaný baþlat
        GlobalCoin.coinCount = 0;//altýnlarý sýfýrla
        SceneManager.LoadScene(GlobalLevel.levelNumber);//diðer seviyeye git
    }
}
