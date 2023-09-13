using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        // deleteWallと衝突したら
        if (other.gameObject.CompareTag("Wall"))
        {
            // プレイヤーを消滅させる
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // deleteWallと衝突したら
        if (other.gameObject.CompareTag("Item"))
        {
            // プレイヤーを消滅させる
            Destroy(other.gameObject);
        }
    }
}
