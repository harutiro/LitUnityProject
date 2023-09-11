using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 重力がかかる向きを指定する
    /// </summary>
    public bool isNormalGravity = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 重力を反転する
            isNormalGravity = !isNormalGravity;
            ChangeGravity();
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
}
