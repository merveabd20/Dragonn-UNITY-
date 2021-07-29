using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 1.5f;//oyuncu h�z�
    public GameObject playerDragon;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {//a tu�una bas�ld���nda olacaklar -->sol
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {//d tu�una bas�ld���nda olacaklar -->sa�
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {//w tu�una bas�ld���nda olacaklar -->ileri
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            playerDragon.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {//s tu�una bas�ld���nda olacaklar -->geri
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
