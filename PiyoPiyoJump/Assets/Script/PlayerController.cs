using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody playerRigidbody;
    int score = 0;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.velocity = new Vector3(0, 6, 0);
            audioSource.Play();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log(score);
    }
}
