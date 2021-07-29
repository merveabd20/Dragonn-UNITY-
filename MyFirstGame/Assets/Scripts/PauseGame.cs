using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)//oyun durdur
            {
                Time.timeScale = 0;//zamaný durdur
                gamePaused = true;//deðiþkene true deðerini ata
                Cursor.visible = true;//imleci göster
                this.GetComponent<AudioSource>().Pause();//müziði durdur
                pauseMenu.SetActive(true);//menü canvasýný göster
            }
            else
            {//oyun devam
                pauseMenu.SetActive(false);//menüyü gizle
                this.GetComponent<AudioSource>().UnPause();//müziði baþlat
                gamePaused = false;//deðiþkene false deðerini at
                Time.timeScale = 1; //zamaný baþlat
            }
        }
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);//menüyü gizle
        this.GetComponent<AudioSource>().UnPause();//müziði baþlat
        gamePaused = false;//deðiþkene false deðerini ata
        Time.timeScale = 1;//zamaný baþlat
    }
    
    public void RestartLevel()
    {//seviyeyi baþtan baþlat
        Time.timeScale = 1;//zamaný baþlat
        SceneManager.LoadScene(2);//ikinci sahneye git
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;//zamaný baþlat
        GlobalLevel.levelNumber = 3;//leveli sýfýrla
        SceneManager.LoadScene(1);//menü kýsmýna git
    }
}
