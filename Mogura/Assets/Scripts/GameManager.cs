using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool isPlaying = false;

    public float timer;
    public Text timerText;

    public static int score = 0;
    public Text scoreText;
    int comboCount;
    public Text comboText;

    public GameObject scoreBoardImage;
    public GameObject stopText;
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString("f0") + "点";
        comboCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            timer -= Time.deltaTime;
            timerText.text = "あと" + timer.ToString("f0") + "秒";
            if (timer <= 0.0f)
            {
                timer = 0.0f;
                isPlaying = false;
                scoreBoardImage.SetActive(false);
                stopText.SetActive(true);
                Invoke("DisplayResult", 2);
            }
        }
    }

    public void CalculateScore(string tag)
    {
        if(tag == "OK")
        {
            score += 10;
            comboCount++;
            if(comboCount >= 2)
            {
                comboText.text = comboCount.ToString("f0") + "コンボ！";
            }
        }
        else if(tag == "Special")
        {
            score += 10 * comboCount + 50;
            if(comboCount > 2)
            {
                comboText.text = comboCount.ToString("f0") + "コンボ！スペシャル！";
            }
        }
        else if(tag == "NG")
        {
            comboCount = 0;
            comboText.text = "";
        }

        scoreText.text = score.ToString("f0") + "点";
    }

    void DisplayResult()
    {
        SceneManager.LoadScene("Result");
    }

    public void OnClickStart()
    {
        startButton.SetActive(false);
        this.GetComponent<AudioManager>().GameStart();
    }
}

