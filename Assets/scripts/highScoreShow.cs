using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreShow : MonoBehaviour


{

       public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //show the text high score and get the high score from the player prefs
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
        
    }
}
