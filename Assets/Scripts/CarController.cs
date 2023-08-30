using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    private Vector3 moveForce;
    
    

    [Header("Car Controller")]
    public float moveSpeed = 50;
    public float maxSpeed=15;
    public float Drag = 0.98f;
    public float steerAngle=20;
    public float Traction = 1;
    

    

    // Update is called once per frame
    void FixedUpdate()
    {

        //moving
        ///*moveInput =*/
        moveForce += transform.forward * moveSpeed * SimpleInput.GetAxis("Vertical") * Time.fixedDeltaTime;
        transform.position += moveForce * Time.fixedDeltaTime;
        // steering 
        float steerInput = SimpleInput.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * moveForce.magnitude * steerAngle * Time.fixedDeltaTime);



        // drag and max speed limit
        moveForce *= Drag;
        moveForce = Vector3.ClampMagnitude(moveForce, maxSpeed);

        Debug.DrawRay(transform.position, moveForce.normalized * 3);
        Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
        moveForce = Vector3.Lerp(moveForce.normalized, transform.forward, Traction * Time.deltaTime) * moveForce.magnitude;
    }
    
    //public void OnTriggerEnter(Collider other)
    
    //{
    //    if (other.tag == "Respawn")
    //    {
    //        if (playerWin == true && playerLose == false)
    //        {
    //            fadeout.Start();
    //        }
    //        else
    //        {
    //            playerLose = true;
    //            isFinish = true;
    //            fadeout.PanelFadeIn();
    //            gameOver.Play();
    //            gameOverAd.ShowAd();
                
    //        }
            
    //        //fadein.gameObject.SetActive(false);
    //        //LevelComplete.gameObject.SetActive(false);
    //    }
    //    if (other.tag == "Finish")
    //    {
    //        if (playerWin == false && playerLose == true)
    //        {
    //            fadein.Start();
    //        }
    //        else
    //        {
    //            coinsInLevel = Random.Range(100, 500);

    //            currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
    //            if (currentLevel >= PlayerPrefs.GetInt("Level"))
    //            {
    //                PlayerPrefs.SetInt("Level", currentLevel);

    //            }
    //            playerWin = true;
    //            finish.Play();
    //            fadein.PanelFadeIn();
    //            LevelComplete.Play();
    //            gameOverAd.ShowAd();
                

    //            SetScore(coinsInLevel + AllCoins.AllCoins);
                
    //        }
            
    //    }

   // }
    //public void NextLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    //}
    //public void GameOver()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    //}
}
