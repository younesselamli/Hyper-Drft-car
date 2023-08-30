using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    int levelInlocked;
    public Button[] levelButton;
    //public Image[] locked;

    // Start is called before the first frame update
    void Start()
    {
        levelInlocked = PlayerPrefs.GetInt("Level",1);

        for (int i = 0; i < levelButton.Length; i++)
        {

            levelButton[i].interactable = false;
            levelButton[i].image.color = Color.yellow;
            


        }
        for (int i = 0; i < levelInlocked; i++)
        {
            levelButton[i].interactable = true;
            levelButton[i].image.color = Color.white;
            levelButton[i].GetComponentInChildren<Image>().GetComponentInChildren<CanvasGroup>().alpha = 0f;
            //locked[i].gameObject.SetActive(false);
        }
        //for (int i = 0; i < locked.Length; i++)
        //{

        //    locked[i].gameObject.SetActive(true);
        //}
        
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
