using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    void Update()
    {//LookAt methodu ile kameran�n oyuncuyu takip etmesi sa�lanm��t�r.
        transform.LookAt(player.transform);
    }
}
