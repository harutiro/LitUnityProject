using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpController : MonoBehaviour
{

    int playerHp = 10;

    // Start is called before the first frame update
    void Start()
    {
        HPCounter.HPCount = playerHp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerDamege()
    {
        Debug.Log("player: " + playerHp);
        HPCounter.HPCount = playerHp;
        playerHp--;

        if (playerHp == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
