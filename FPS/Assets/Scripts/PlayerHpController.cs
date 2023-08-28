using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpController : MonoBehaviour
{

    int playerHp = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerDamage()
    {
        Debug.Log("player: " + playerHp);
        playerHp--;

        if (playerHp == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
