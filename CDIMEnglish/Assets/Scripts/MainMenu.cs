using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void btn_Start()
    {
        SceneManager.LoadScene("MainGame");
    }
   
    public void btn_Exit()
    {
        Application.Quit();
    }
}
