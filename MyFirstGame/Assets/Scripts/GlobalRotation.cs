using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalRotation : MonoBehaviour
{
    public float rotateSpeed=0.5f;//d�nme h�z�
    void Update()
    {//engellerin ve alt�nlar�n d�nmesi sa�lanm��t�r
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);
    }
}
