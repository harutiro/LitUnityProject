using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpController : MonoBehaviour
{
    int enemyHp = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Damege() 
    {

        Debug.Log("Enemy: " + enemyHp) ;
        enemyHp--;

        if(enemyHp == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           other.SendMessage("PlayerDamege");

        }
    }
}
