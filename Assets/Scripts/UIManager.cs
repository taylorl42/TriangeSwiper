
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public float score;
    public Text highScoreText;
    public Text scoreText;
    public Text startText;
    public Text gameOverText;
    public Text tutorialText;
    public Text unlockText;
    public Text newRecordText;
    public GameObject player;
    

    void Start () {
        highScoreText.text = "Best: " + 
            PlayerPrefs.GetInt("score" + PlayerPrefs.GetInt("Level"), 0).ToString();
        score = 0;
        scoreText.text = "";
    }


    public void IncrementScore()
    {
        score += Time.deltaTime;
        score = Mathf.Round(score * 100f) / 100f;
        
        scoreText.text = score.ToString();
    }
    
    public void RemoveStartText()
    {
        startText.text = "";
    }

    public void GameOver()
    {


        //set new highscore
        if (score > PlayerPrefs.GetFloat("score" + PlayerPrefs.GetInt("Level"), 0))
        {
            PlayerPrefs.SetFloat("score" + PlayerPrefs.GetInt("Level"), score);
            newRecordText.text = "*New Record*";
        }


        if (PlayerPrefs.GetInt("UnlockedLevels",1) == 1 && PlayerPrefs.GetInt("Level") == 1
            && score >= 30)
        {
            PlayerPrefs.SetInt("UnlockedLevels", 2);
            unlockText.text = "New Level Unlocked";
        }

        if (PlayerPrefs.GetInt("UnlockedLevels",1) == 2 && PlayerPrefs.GetInt("Level") == 2
            && score >= 30)
        {
            PlayerPrefs.SetInt("UnlockedLevels", 3);
            unlockText.text = "New Level Unlocked";
        }

        if (PlayerPrefs.GetInt("UnlockedLevels",1) == 3 && PlayerPrefs.GetInt("Level") == 3
            && score >= 30)
        {
            PlayerPrefs.SetInt("UnlockedLevels", 4);
            unlockText.text = "New Level Unlocked";
        }

        if (PlayerPrefs.GetInt("UnlockedLevels",1) == 4 && PlayerPrefs.GetInt("Level") == 4
            && score >= 30)
        {
            PlayerPrefs.SetInt("UnlockedLevels", 5);
            unlockText.text = "New Level Unlocked";
        }

        if (PlayerPrefs.GetInt("UnlockedLevels",1) == 5 && PlayerPrefs.GetInt("Level") == 5
            && score >= 30)
        {
            PlayerPrefs.SetInt("UnlockedLevels", 6);
            unlockText.text = "New Level Unlocked";
        }

        highScoreText.text = "Best: " + PlayerPrefs.GetFloat("score" + PlayerPrefs.GetInt("Level"), 0);
        gameOverText.text = "Game Over\nTap to Restart";

       

    }

    public void Restart()
    {
        gameOverText.text = "";
        highScoreText.text = "";
        unlockText.text = "";
        newRecordText.text = "";
        score = 0;
        player.SetActive(true);
    }
}
