using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalRotation : MonoBehaviour
{
    public float rotateSpeed=0.5f;//dönme hýzý
    void Update()
    {//engellerin ve altýnlarýn dönmesi saðlanmýþtýr
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
    }
}
