using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ProcedToMenu());//methoda git
    }

    IEnumerator ProcedToMenu()
    {
        yield return new WaitForSeconds(6);//6s bekle
        SceneManager.LoadScene(1);//1.sahneye git
    }
}
