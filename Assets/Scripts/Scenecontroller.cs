using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenecontroller : MonoBehaviour
{
    public Text level;
    public int current;

    private void Start()
    {
        current = PlayerPrefs.GetInt("CurrentLevel", 0)+1;
        level.text = "Current Level : " + current.ToString();
        //level.text ="Current Level : "+( PlayerPrefs.GetInt("CurrentLevel", 1).ToString() ) ++1;
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
}
