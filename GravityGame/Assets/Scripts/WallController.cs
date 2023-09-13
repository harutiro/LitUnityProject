using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    /// <summary>
    /// ゲームオブジェクトを消滅させる位置を指定する
    /// </summary>
    public float deadLine = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPlaying)
        {
            transform.position += transform.forward * (GameManager.speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // プレイヤーと衝突したら
        if (other.gameObject.CompareTag("deleteWall"))
        {
            // プレイヤーを消滅させる
            Destroy(gameObject);
        }
    }
}
