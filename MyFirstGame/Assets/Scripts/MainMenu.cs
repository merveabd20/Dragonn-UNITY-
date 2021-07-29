using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public int loadLevel;
    public GameObject hintBox;
    public int hintNum;

    private void Start()
    {//baþlangýç ekranýna rasgele mesaj ver
        hintNum = Random.Range(1, 4);//random sayý üret
        if (hintNum == 1)
        {
            hintBox.GetComponent<Text>().text = "Seviyeyi Tamamlamak Ýçin 4 Jeton Toplamalýsýn!";
        }
        if (hintNum == 2)
        {
            hintBox.GetComponent<Text>().text = "3 Level Var. Zamanýn Tükenmeden Levellarý Tamamlamalýsýn!";
        }
        if (hintNum == 3)
        {
            hintBox.GetComponent<Text>().text = "Engellere Çarpma!";
        }
    }
    public void StartGame()
    {//yeni oyuna baþla
        GlobalLevel.levelNumber = 3;//ilk seviyeye at
        SceneManager.LoadScene(GlobalLevel.levelNumber);//oyunu baþlat
    }

    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LevelLoadNum");//kaydedilmiþ level numarasýný ata
        if(loadLevel < 3)//3'ten küçükse ilk seviyeden baþlat
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {//kaldýðý yerden baþlat
            GlobalLevel.levelNumber = loadLevel;//kaydedilmiþ level numarasýný deðiþkene atae
            SceneManager.LoadScene(loadLevel);//seviyeyi baþlat
        }
    }

    public void QuitGame()
    {
        Application.Quit();//oyundan çýk
    }

}
