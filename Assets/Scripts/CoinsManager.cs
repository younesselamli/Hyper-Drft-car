using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public int AllCoins;
    public Text textAllCoins;

    // Start is called before the first frame update
    void Update()
    {
        AllCoins = PlayerPrefs.GetInt("cs");
        string.Format("Score: {0:#,#}", AllCoins);
        textAllCoins.text = AllCoins.ToString("#,#");
    }
    
}
