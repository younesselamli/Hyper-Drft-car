using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel >= PlayerPrefs.GetInt("Level")){
            PlayerPrefs.SetInt("Level", currentLevel);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
