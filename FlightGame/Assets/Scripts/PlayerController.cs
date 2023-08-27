using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 自動で前に進む
        transform.position += new Vector3(0, 0, playerSpeed * Time.deltaTime);

        // 矢印操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -playerSpeed * Time.deltaTime, 0);
        }


        // Goal
        if(transform.position.z >= 150)
        {
            SceneManager.LoadScene("Goal");
        }
    }
}
