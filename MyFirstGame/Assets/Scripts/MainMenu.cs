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
    {//ba�lang�� ekran�na rasgele mesaj ver
        hintNum = Random.Range(1, 4);//random say� �ret
        if (hintNum == 1)
        {
            hintBox.GetComponent<Text>().text = "Seviyeyi Tamamlamak ��in 4 Jeton Toplamal�s�n!";
        }
        if (hintNum == 2)
        {
            hintBox.GetComponent<Text>().text = "3 Level Var. Zaman�n T�kenmeden Levellar� Tamamlamal�s�n!";
        }
        if (hintNum == 3)
        {
            hintBox.GetComponent<Text>().text = "Engellere �arpma!";
        }
    }
    public void StartGame()
    {//yeni oyuna ba�la
        GlobalLevel.levelNumber = 3;//ilk seviyeye at
        SceneManager.LoadScene(GlobalLevel.levelNumber);//oyunu ba�lat
    }

    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LevelLoadNum");//kaydedilmi� level numaras�n� ata
        if(loadLevel < 3)//3'ten k���kse ilk seviyeden ba�lat
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {//kald��� yerden ba�lat
            GlobalLevel.levelNumber = loadLevel;//kaydedilmi� level numaras�n� de�i�kene atae
            SceneManager.LoadScene(loadLevel);//seviyeyi ba�lat
        }
    }

    public void QuitGame()
    {
        Application.Quit();//oyundan ��k
    }

}
