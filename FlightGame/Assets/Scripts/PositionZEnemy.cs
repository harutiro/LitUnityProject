using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionZEnemy : MonoBehaviour
{

    float enemySpied = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -enemySpied * Time.deltaTime);
    }
}
