using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public void Cýkýs()
    {
        Application.Quit();
    }
    public void Basla()
    {
        SceneManager.LoadScene(1);
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene(2);
    }
    public void Geri()
    {
        SceneManager.LoadScene(0);
    }

   
}