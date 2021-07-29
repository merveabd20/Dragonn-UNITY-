using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int levelNumber = 3;//screenler sýralandýðýnda leveller 3'ten baþlamaktadýr. o yüzden level deðiþkenimizi üçe eþitledik
    public int internalNum;
    void Start()
    {
        
    }

    void Update()
    {
        internalNum = levelNumber; 
    }
}
