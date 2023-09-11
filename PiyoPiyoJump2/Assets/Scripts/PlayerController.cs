using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody playerRigidbody;
    AudioSource audioSource;

    public Text scoreText;

    public GameObject gameOverUI;
    public Text gameOverScoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.velocity = new Vector3(0, 6, 0);
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GameOver");
        //SceneManager.LoadScene("GameOver");

        gameOverScoreText.text = "Score : " + score.ToString();
        gameOverUI.SetActive(true);
    }

    int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        scoreText.text = "Score : " + score.ToString();
    }
}
