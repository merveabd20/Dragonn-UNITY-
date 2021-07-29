using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObstacleCollide : MonoBehaviour
{
    public GameObject obstacleText;
    public GameObject fadeOut;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {//engelle oyuncu çarpýþtý mý
        if (other.tag == "Player")
        {
            player.GetComponent<PlayerControls>().enabled = false;//oyuncuyu durdur
            obstacleText.SetActive(true);//engele çarptýn mesajýný ver
            fadeOut.SetActive(true);//animasyonu baþlat
            StartCoroutine(RespawningLevel());//methoda git
        }
    }

    IEnumerator RespawningLevel()
    {//yeniden baþlat
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
