using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelInOneScene : MonoBehaviour
{
    public List<GameObject> levels = new List<GameObject>(); // list of level prefabs

    public int currentLevelIndex = 0;
    public int level = 0;// index of the current level

    private void Start()
    {
        LoadProgress();
        /*LoadLevel(currentLevelIndex);*/ // load the first level on start up
    }

    public void LoadLevel(int index)
    {
        if (index < 0 || index >= levels.Count)
        { // check if the index is valid 
            Debug.LogError("Invalid level index"); // log an error if not valid 
            return;
        }

        //if (currentLevelIndex != -1)
        //{ // check if the current level is valid 
        //    Destroy(levels[currentLevelIndex]); // destroy the old level 
        //}

        GameObject newLevel = Instantiate(levels[index]); // instantiate a new level from the list of prefabs 

        currentLevelIndex = index; // set the current level to the new one 


        /*SaveProgress();*/ // save progress after loading a new level 
    }

    public void SaveProgress()
    {
        PlayerPrefs.SetInt("CurrentLevel", currentLevelIndex ); // save the player's progress in PlayerPrefs with key "CurrentLevel" and value "currentLevelIndex"  										  
    }
    public void NextLevel()
    {
        level+=1;
        currentLevelIndex ++;
        PlayerPrefs.SetInt("CurrentLevel", currentLevelIndex );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("level complete");
    }

    public void LoadProgress()
    {
        int savedProgress = PlayerPrefs.GetInt("CurrentLevel", 0); // get saved progress from PlayerPrefs with key "CurrentLevel" and default value 0  

        LoadLevel(savedProgress); // load saved progress as a new level  			  
    }
}
