using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chncanh : MonoBehaviour
{
    //khai bao bien
    public Animator anir;

  public void bnt()
    {
        //lenh chay ham co the tam dung
        StartCoroutine(LoadScene());

    }
    IEnumerator LoadScene()
    {
        anir.SetTrigger("chuyen");
        //doi de chn canh
        yield return new WaitForSeconds(0.5f);
        anir.SetTrigger("mo");
        yield return new WaitForSeconds(0.4f);
        //chn scene
        SceneManager.LoadScene(1);
    }
}
