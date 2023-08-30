using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarManager : MonoBehaviour
{
    public LevelInOneScene InOneScene;

    private Vector3 moveForce;
    public CameraFollowCar shake;
    public Interstitial gameOverAd;

    [Header("Level Controller")]
    public bool isFinish = false;
    //public ParticleSystem finish;
    public StoreAnimation fadein, fadeout;
    public AudioSource gameOver, LevelComplete;
   public bool playerWin = false;
   public bool playerLose = false;
    public int currentLevel;
    public Text TextLevel;
    [Header("Coins")]
    public int coinsInLevel;
    public CoinsManager AllCoins;
    public Text CoinsInLevelComplete;

    public void SetScore(int newScore, bool save = true)
    {
        
        AllCoins.AllCoins = newScore;
        CoinsInLevelComplete.text = " + " + coinsInLevel.ToString();
        if (save)
        {
            PlayerPrefs.SetInt("cs", AllCoins.AllCoins);
        }
    }

    private void Start()
    {
        SetScore(PlayerPrefs.GetInt("cs"), false);
        TextLevel.text = "Level : " + (InOneScene.currentLevelIndex+ 1) ;


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            if (playerWin == true && playerLose == false)
            {
                fadeout.Start();
            }
            else
            {
                playerLose = true;
                isFinish = true;
                fadeout.PanelFadeIn();
                gameOver.Play();
                gameOverAd.ShowAd();
            }
            
        }
        if (other.tag == "Finish")
            {
            if (playerWin == false && playerLose == true)
            {
                fadein.Start();
            }
            else
            {
                coinsInLevel = Random.Range(100, 500);


                playerWin = true;
                //finish.Play();
                fadein.PanelFadeIn();
                LevelComplete.Play();
                gameOverAd.ShowAd();


                SetScore(coinsInLevel + AllCoins.AllCoins);

            }               

        }
    }

    public void NextLevel()
    {

        InOneScene.NextLevel();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Home(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

}
