using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 10;

    float x;
    float y;
    Rigidbody playerRigidbody;

    public GameObject gameOverCanvas;
    public GameObject gameClearCanvas;
    bool isPlaying = true;

    public GameObject cameraRemover;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying == true)
        {
            transform.position += new Vector3(0, 0, playerSpeed * Time.deltaTime);

            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            playerRigidbody.velocity += new Vector3(x, y, 0);

            transform.rotation = Quaternion.AngleAxis(x * -30, Vector3.forward);
        }
        

        if(transform.position.z >= 150)
        {
            gameClearCanvas.SetActive(true);
            cameraRemover.SendMessage("RemoveCamera");
        }
    }

    void GameOver()
    {
        isPlaying = false;
        gameOverCanvas.SetActive(true);
    }
}
