using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    public GameObject[] field;
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < field.Length; i++)
        {
            field[i].transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }

        if(field[0].transform.position.z < -600)
        {
            field[0].transform.position = new Vector3(-150, -20, 900);
        }
        else if(field[1].transform.position.z < -600)
        {
            field[1].transform.position = new Vector3(-150, -20, 900);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
