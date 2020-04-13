using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    int score = 0;
    public GameObject gOverPanel;
    public GameObject pausePanel;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gOverPanel.activeInHierarchy)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                //restart game
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                //quit game
                print("attempting to quit");
                Application.Quit();
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                //start menu
                Time.timeScale = 1;
                SceneManager.LoadScene(sceneName: "StartRoom");
            }
        }
        else if (pausePanel.activeInHierarchy)
        {
            //resume
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                pausePanel.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {

                Time.timeScale = 1;
                SceneManager.LoadScene(sceneName: "StartRoom");
            }
        }
    }

    public void incrementScore()
    {
        score++;
        scoreText.text = "Score\n" + score;
        //print(score);
    }
    public void gameOver()
    {
        Time.timeScale = 0;
        gOverPanel.SetActive(true);
    }
}
