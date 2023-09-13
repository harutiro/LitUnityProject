using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    /// <summary>
    /// ScoreUI
    /// </summary>
    public static Text scoreUI;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void ScoreUpdate(int score)
    {
        if (scoreUI != null)
        {
            scoreUI.text = score.ToString();
        }
    }
}
