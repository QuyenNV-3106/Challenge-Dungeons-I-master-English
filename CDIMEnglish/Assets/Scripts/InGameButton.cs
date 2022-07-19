using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public void btn_Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void btn_Challenge()
    {
        SceneManager.LoadScene("GameScene");
    }
}
