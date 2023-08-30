using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreSystem : MonoBehaviour
{
    
    public Interstitial buying;
    public CoinsManager coinsManager;
    public Text coinsText;
    public int mycoins;
    public int cp2;
    public Button play1,play2,play3,play4,play5,play6,play7;
    public bool isUnlocked;
    [Header("Cars")]
    //public GameObject mainCar;
    public GameObject car1,car2,car3,car4,car5,car6,car7;
    public int selectedCar;
    [Header("New Car Sound effect")]
    public AudioSource SFX;
    public AudioSource nocoins;

    //public Animator carAnim;
    



    private void Start()
    {

       




    }
    private void Update()
    {
        

        mycoins = PlayerPrefs.GetInt("cs");

        selectedCar =PlayerPrefs.GetInt("carPlayer");


        if (isUnlocked = (PlayerPrefs.GetInt("locked1") != 0))
        {
            play1.gameObject.SetActive(true);
        }
        if (isUnlocked = (PlayerPrefs.GetInt("locked2") != 0))
        {
            play2.gameObject.SetActive(true);
        }if (isUnlocked = (PlayerPrefs.GetInt("locked3") != 0))
        {
            play3.gameObject.SetActive(true);
        }if (isUnlocked = (PlayerPrefs.GetInt("locked4") != 0))
        {
            play4.gameObject.SetActive(true);
        }if (isUnlocked = (PlayerPrefs.GetInt("locked5") != 0))
        {
            play5.gameObject.SetActive(true);
        }if (isUnlocked = (PlayerPrefs.GetInt("locked6") != 0))
        {
            play6.gameObject.SetActive(true);
        }if (isUnlocked = (PlayerPrefs.GetInt("locked7") != 0))
        {
            play7.gameObject.SetActive(true);
        }
        if (selectedCar == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            //PlayCar1();
        }
        if (selectedCar == 2)
        {
            car1.SetActive(false);
            car2.SetActive(true);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            //PlayCar2();
        }
        if (selectedCar == 3)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(true);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            //PlayCar3();
        }
        if (selectedCar == 4)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(true);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            //PlayCar4();
        }
        if (selectedCar == 5)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(true);
            car6.SetActive(false);
            car7.SetActive(false);
            //PlayCar5();
        }
        if (selectedCar == 6)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(true);
            car7.SetActive(false);
            //PlayCar6();
        }
        if (selectedCar == 7)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(true);
            //PlayCar7();
        }
    }
    public void FixedUpdate()
    {



    }

    public void Buy1()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play1.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked1", (isUnlocked ? 1 : 0));
            SFX.Play();
            buying.ShowAd();
           // buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    }
    public void Buy2()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play2.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked2", (isUnlocked ? 1 : 0));
            SFX.Play();
           buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    } public void Buy3()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play3.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked3", (isUnlocked ? 1 : 0));
            SFX.Play();
            buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    } public void Buy4()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play4.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked4", (isUnlocked ? 1 : 0));
            SFX.Play();
            buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    } public void Buy5()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play5.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked5", (isUnlocked ? 1 : 0));
            SFX.Play();
            buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    } public void Buy6()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play6.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked6", (isUnlocked ? 1 : 0));
            SFX.Play();
            buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    } public void Buy7()
    {
        if (coinsManager.AllCoins>=cp2)
        {
            coinsManager.AllCoins -= cp2;
            isUnlocked = true;
            play7.gameObject.SetActive(true);
            coinsText.text = mycoins.ToString();
            PlayerPrefs.SetInt("cs", coinsManager.AllCoins);
            PlayerPrefs.SetInt("locked7", (isUnlocked ? 1 : 0));
            SFX.Play();
           buying.ShowAd();
        }
        else
        {
            Debug.Log("No enough coins");
            nocoins.Play();
        }
    }










    public void PlayCar1()
    {

        selectedCar = 1;
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
        car5.SetActive(false);
        car6.SetActive(false);
        car7.SetActive(false);
        car1.SetActive(true);
        PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //carAnim.SetBool("anim", false);

    }
    public void PlayCar2()
    {

        selectedCar = 2;
        car1.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
        car5.SetActive(false);
        car6.SetActive(false);
        car7.SetActive(false);
        car2.SetActive(true);
        PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }
    public void PlayCar3()
    {
        selectedCar = 3;
        car1.SetActive(false);
        car2.SetActive(false);
        car4.SetActive(false);
        car5.SetActive(false);
        car6.SetActive(false);
        car7.SetActive(false);
        car3.SetActive(true);
        PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }
    public void PlayCar4()
    {

        selectedCar = 4;
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
        car5.SetActive(false);
        car6.SetActive(false);
        car7.SetActive(false);
        car4.SetActive(true);
        PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }
    public void PlayCar5()
    {
        
            selectedCar = 5;
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car5.SetActive(true);
            PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }
    public void PlayCar6()
    {
        
            selectedCar = 6;
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car7.SetActive(false);
            car6.SetActive(true);
            PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }
    public void PlayCar7()
    {
        
            selectedCar = 7;
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(true);
            PlayerPrefs.SetInt("carPlayer", selectedCar);
        SceneManager.LoadScene(0);
        //carAnim.SetBool("anim", true);

    }


}
