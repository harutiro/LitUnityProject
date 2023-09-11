using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class WallCreator : MonoBehaviour
{
    /// <summary>
    /// 壁のプレハブを指定する
    /// </summary>
    public GameObject wallPrefab;
    
    /// <summary>
    /// 壁の生成時間を保存する
    /// </summary>
    float timer = 0.0f;
    
    /// <summary>
    /// 生存間隔を指定する
    /// </summary>
    public float interval = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 経過時間を加算する
        if (timer > interval) // 経過時間が生存間隔を超えたら
        {
            Instantiate(wallPrefab, transform.position, transform.rotation); // 壁を生成する
            timer = 0.0f; // 経過時間をリセットする
        }
    }
}
