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
                Time.timeScale = 0;//zaman� durdur
                gamePaused = true;//de�i�kene true de�erini ata
                Cursor.visible = true;//imleci g�ster
                this.GetComponent<AudioSource>().Pause();//m�zi�i durdur
                pauseMenu.SetActive(true);//men� canvas�n� g�ster
            }
            else
            {//oyun devam
                pauseMenu.SetActive(false);//men�y� gizle
                this.GetComponent<AudioSource>().UnPause();//m�zi�i ba�lat
                gamePaused = false;//de�i�kene false de�erini at
                Time.timeScale = 1; //zaman� ba�lat
            }
        }
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);//men�y� gizle
        this.GetComponent<AudioSource>().UnPause();//m�zi�i ba�lat
        gamePaused = false;//de�i�kene false de�erini ata
        Time.timeScale = 1;//zaman� ba�lat
    }
    
    public void RestartLevel()
    {//seviyeyi ba�tan ba�lat
        Time.timeScale = 1;//zaman� ba�lat
        SceneManager.LoadScene(2);//ikinci sahneye git
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;//zaman� ba�lat
        GlobalLevel.levelNumber = 3;//leveli s�f�rla
        SceneManager.LoadScene(1);//men� k�sm�na git
    }
}
