using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    void Update()
    {//LookAt methodu ile kameranýn oyuncuyu takip etmesi saðlanmýþtýr.
        transform.LookAt(player.transform);
    }
}
