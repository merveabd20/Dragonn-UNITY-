using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int levelNumber = 3;//screenler sıralandığında leveller 3'ten başlamaktadır. o yüzden level değişkenimizi üçe eşitledik
    public int internalNum;
    void Start()
    {
        
    }

    void Update()
    {
        internalNum = levelNumber; 
    }
}
