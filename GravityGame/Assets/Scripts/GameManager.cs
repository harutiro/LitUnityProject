using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    /// <summary>
    /// デフォルトのwallsを指定する
    /// </summary>
    public GameObject defaultWalls;
    
    /// <summary>
    /// Player
    /// </summary>
    public GameObject player;
    
    /// <summary>
    /// 壁のスピードを指定する
    /// </summary>
    public static float speed = 6.0f;
    
    /// <summary>
    /// Play中かどうかを保存する
    /// </summary>
    public static bool isPlaying = true;
    
    /// <summary>
    /// スコアの保存
    /// </summary>
    public static int score = 0;
    
    /// <summary>
    /// ScoreUI
    /// </summary>
    public Text scoreUI;
    
    /// <summary>
    /// MessageUI
    /// </summary>
    public Text messageUI;
    
    /// <summary>
    /// StartButtonのUI
    /// </summary>
    public Button startButtonUI;
    
    /// <summary>
    /// RetryButtonのUI
    /// </summary>
    public Button retryButtonUI;

    
    // Start is called before the first frame update
    void Start()
    {
        TitleView();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void TitleView()
    {
        scoreUI.gameObject.SetActive(false);
        messageUI.text = "GravityGame";
        retryButtonUI.gameObject.SetActive(false);
        isPlaying = false;
    }
    
    public void GameStart()
    {
        Debug.Log("GameStart");
        
        // ItemとWallをすべて削除する
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (GameObject wall in walls)
        {
            Destroy(wall);
        }
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            Destroy(item);
        }
        
        // defaultWallsを複製する
        Instantiate(defaultWalls);
        
        // Playerを0,0,0に移動する
        player.transform.position = new Vector3(0,0,0);
        
        scoreUI.gameObject.SetActive(true);
        messageUI.gameObject.SetActive(false);
        retryButtonUI.gameObject.SetActive(false);
        startButtonUI.gameObject.SetActive(false);
        
        isPlaying = true;
        score = 0;
        scoreUI.text = score.ToString();

    }
}
