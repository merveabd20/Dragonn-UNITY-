using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 1.5f;//oyuncu hýzý
    public GameObject playerDragon;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {//a tuþuna basýldýðýnda olacaklar -->sol
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {//d tuþuna basýldýðýnda olacaklar -->sað
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {//w tuþuna basýldýðýnda olacaklar -->ileri
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {//s tuþuna basýldýðýnda olacaklar -->geri
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -1);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            playerDragon.transform.localRotation = Quaternion.Euler(0, 45, 0);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            playerDragon.transform.localRotation = Quaternion.Euler(0, 135, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            playerDragon.transform.localRotation = Quaternion.Euler(0, 225, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            playerDragon.transform.localRotation = Quaternion.Euler(0, 315, 0);
        }
    }
}
