using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    void Update()
    {//LookAt methodu ile kameranın oyuncuyu takip etmesi sağlanmıştır.
        transform.LookAt(player.transform);
    }
}
