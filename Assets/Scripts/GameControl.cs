using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl instance;
    public GameObject GameOverText;
    public Text ScoreText;

    public bool GameOver = false;
    public float ScrollSpeed = -1f;

    private int Score = 0;

    // Start is called before the first frame update
    void Awake()
    {

        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameOver == true && Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }

    public void BirdScored()
    {

        if (GameOver)
            return;

        Score++;
        ScoreText.text = "Score : " + Score.ToString();

    }

    public void BirdDied ()
    {

        GameOverText.SetActive(true);
        GameOver = true;

    }

}
