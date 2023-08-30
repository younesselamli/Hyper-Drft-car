using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCar : MonoBehaviour
{
    public GameObject car1,car2,car3,car4,car5,car6,car7;
    public int selectedCar = 1;

    // Start is called before the first frame update
    void Start()
    {
        selectedCar = PlayerPrefs.GetInt("carPlayer");
        //GameObject prefab = cars[selectedCar];
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedCar == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
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
        }

    }
}
