
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 重力がかかる向きを指定する
    /// </summary>
    public bool isNormalGravity = true;
    
    /// <summary>
    /// ScoreTextを指定する
    /// </summary>
    public Text scoreText;
    
    /// <summary>
    /// スコアの保存
    /// </summary>
    public static int score = 0;
    
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPlaying)
        {
            // スペースキーが押されたら
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 重力を反転する
                isNormalGravity = !isNormalGravity;
                ChangeGravity();
            }
        }
    }
    
    /// <summary>
    /// 重力を反転する
    /// </summary>
    void ChangeGravity()
    {
        // 重力を反転する
        Physics.gravity *= -1;
        
        // プレイヤーの向きを反転する
        transform.Rotate(new Vector3(0, 0, 180));
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        
        if (other.gameObject.CompareTag("WallCollider"))
        {
            // ゲームオーバーにする
            GameOver();
        }
        
        // プレイヤーと衝突したら
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("Item");
            Destroy(other.gameObject);
            
            // スコアを加算する
            GameManager.score += 1;
            scoreText.text = GameManager.score.ToString();
        }

    }
    
    public void GameOver()
    {
        messageUI.gameObject.SetActive(true);
        messageUI.text = "GameOver";
        retryButtonUI.gameObject.SetActive(true);
        startButtonUI.gameObject.SetActive(false);
        
        GameManager.isPlaying = false;
    }
}
