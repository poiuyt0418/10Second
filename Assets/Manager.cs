using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int points = 0;
    public Text pText;
    public Text timerText;
    public Text endText;
    float timeLeft = 11;
    bool timer = false;
    public AudioSource win;
    public AudioSource lose;
    // Start is called before the first frame update
    void Start()
    {
        pText.text = "0";
    }

    public void Points()
    {
        points += 1;
        pText.text = points.ToString();
    }

    void GameOver()
    {
        if(points>=5)
        {
            endText.text = "You Win";
            win.Play(0);
            timerText.text = "";
        } else
        {
            endText.text = "You Lose";
            lose.Play(0);
            timerText.text = "";
        }
    }

    public void startTimer()
    {
        timer = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (timer)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = ((int)timeLeft).ToString();
            if (timeLeft < 0)
            {
                timer = false;
                GameOver();
            }
        }
    }
}
