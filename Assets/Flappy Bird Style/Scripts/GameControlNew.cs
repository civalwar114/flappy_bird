using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlNew : MonoBehaviour {
    public GameObject gameoverui;
    public Text scoreText;
    public bool gameOver = false;
    // Use this for initialization

    int score = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (gameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);

            }
        }

	}
    // 사망 처리 함수
    public void BirdDied()
    {
        //게임 오버 ui 호출
        gameoverui.SetActive(true);

        gameOver = true;

    }

    public void BirdSocred()
    {
        score = score + 1;
        //ui 표시
        scoreText.text = "Score : " + score.ToString();

    }

}
