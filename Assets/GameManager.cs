using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    int score = 0;
    static bool isTutorial = false;
    int tutState = 0;
    public GameObject gOverPanel;
    public GameObject pausePanel;
    public GameObject tutorialPanel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI tutorialText;
    bool onHold = false;
    string[] script = { "Welcome to the Flight Simulator Tutorial!\nFollow the instructions below to fly the Falcon!!" ,
    "Good Job! See the death stars in the sky?\nAim with your Mouse and\npress SPACE to fire!!",
        "Another tip : press SHIFT to boost the falcon's speed.\nCareful not to hit the death stars! You'll die :)",
        "You're good to go!\nYou can always lick the Pause button below to go back to the Start Menu" };
    // Start is called before the first frame update
    void Start()
    {
        if (isTutorial)
            tutorialPanel.SetActive(true);
        else
            tutorialPanel.SetActive(false);
        tutorialText.text = script[tutState] + "\nPress N to continue";
        //txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTutorial)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                switch(tutState)
                {
                    case 0:
                    case 1:
                        tutState++;
                        tutorialText.text = script[tutState] + "\nPress N to continue";
                        break;
                    case 2:
                        tutState++;
                        tutorialText.text = script[tutState] + "\nPress N to return to Start Menu";
                        break;
                    case 3:
                        isTutorial = false;
                        SceneManager.LoadScene(sceneName: "StartRoom");
                        break;

                }
            }
        }
        
        /*

            if(tutState==0)
            {
                float movement = Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") + Input.GetAxis("Fire1") + Input.GetAxis("Fire2");
                if (!onHold && movement != 0)
                {
                    Invoke("ChangeScript", 5);
                    onHold = true;
                }

            }
            else if(tutState==1)
            {
                if (Input.GetKeyDown("space"))
                {
                    Invoke("ChangeScript", 5);
                    onHold = true;
                }
            }
            else if(tutState==2)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Invoke("ChangeScript", 5);
                    onHold = true;
                }
            }*/
        
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

    public void setTutorial(bool val)
    {
        isTutorial = val;   
    }
    public bool getTutorial()
    {
        return isTutorial;
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
