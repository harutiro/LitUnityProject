using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 楽譜のファイルを保存する変数
    public TextAsset textAsset;
    // Canvasを保存する
    public GameObject canvas;
    // ノーツを保存する変数を宣言する
    public GameObject notesButton;
    // ノーツを生成する位置を保存する配列を宣言する
    public GameObject[] generatePositions;


    public int currentScore;
    public Text scoreText;


    public int clearScore;

    float musicTime;

    float currentMusicTime;

    // Start is called before the first frame update
    void Start()
    {
        currentMusicTime = 0.0f;

        DontDestroyOnLoad(this.gameObject);

        LoadChart();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMusicTime > musicTime)
        {
            SceneManager.LoadScene("Result");
            currentMusicTime = 0.0f;
        }

        currentMusicTime += Time.deltaTime;

        scoreText.text = "score : " + currentScore.ToString();
    }

    void LoadChart()
    {
        string jsonText = textAsset.ToString();
        JsonNode json = JsonNode.Parse(jsonText);


        string clearScoreText = json["clearscore"].Get<string>();
        clearScore = int.Parse(clearScoreText);

        string musicTimeText = json["musictime"].Get<string>();
        musicTime = int.Parse(musicTimeText);

        foreach(JsonNode note in json["notes"])
        {
            string type = note["type"].Get<string>();

            string timingText = note["timing"].Get<string>();

            float timing = float.Parse(timingText);

            if(type == "A1")
            {
                Invoke("GenerateNote", timing);
            }
        }
    }

    void GenerateNote()
    {
        int randomNumber = Random.Range(0, generatePositions.Length);
        Vector3 randomPosition = generatePositions[randomNumber].transform.position;

        // ノーツの生成
        Instantiate(notesButton, randomPosition, Quaternion.identity, canvas.transform);
    }
}
