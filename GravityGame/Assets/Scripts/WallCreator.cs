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
    public float interval = 5.0f;
    
    private Vector3 oldPosition = new Vector3(0,0,-10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPlaying)
        {
            timer += Time.deltaTime; // 経過時間を加算する
            Debug.Log(timer.ToString());
            if (timer > interval) // 経過時間が生存間隔を超えたら
            {
                Vector3 randamPosition = new Vector3(0, Random.Range(-1, 2), 0);
                oldPosition += randamPosition;
                // Debug.Log(randamPosition.ToString());
                // Debug.Log(oldPosition.ToString());
                if(oldPosition.y > 2.0f) oldPosition = new Vector3(0, 2.0f, -10);
                if(oldPosition.y < -2.0f) oldPosition = new Vector3(0, -2.0f, -10);

                Instantiate(wallPrefab, oldPosition, transform.rotation); // 壁を生成する
                timer = 0.0f; // 経過時間をリセットする
            }
        }
    }
}