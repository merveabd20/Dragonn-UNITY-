using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int levelNumber = 3;//screenler s�raland���nda leveller 3'ten ba�lamaktad�r. o y�zden level de�i�kenimizi ��e e�itledik
    public int internalNum;
    void Start()
    {
        
    }

    void Update()
    {
        internalNum = levelNumber; 
    }
}
