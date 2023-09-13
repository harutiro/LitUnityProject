
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 重力がかかる向きを指定する
    /// </summary>
    public bool isNormalGravity = true;
    
    // private int forwardCollisionCount = 0; // 衝突した向きがforwardの回数をカウント
    // private int maxForwardCollisions = 3; // ゲームオーバーになるカウントの閾値
    
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
            GameManager.isPlaying = false;
        }
        
        // プレイヤーと衝突したら
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("Item");
            Destroy(other.gameObject);
            
            // スコアを加算する
            GameManager.score += 1;
            UIController.ScoreUpdate(GameManager.score);
        }

    }
}
