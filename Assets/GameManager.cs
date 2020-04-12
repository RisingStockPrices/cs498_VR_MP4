using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore()
    {
      
        score++;
        scoreText.text = "Score\n" + score;
        //print(score);
    }
}
