using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    [HideInInspector]
    public static Text hiscore;

    public void Start()
    {
        hiscore = GetComponent<Text>();
        hiscore.text = "High Score: " + PlayerPrefs.GetInt("High Score", 0).ToString();
    }

    public void setHiScore()
    {
        int prevScore = ScoreCounter.scoreCountInInt;
        if (prevScore > PlayerPrefs.GetInt("High Score", 0))
        {
            PlayerPrefs.SetInt("High Score", prevScore);
            hiscore.text = prevScore.ToString();
        }
    }

    public void resetScore()
    {
        PlayerPrefs.DeleteAll();
        hiscore.text = "High Score: " + "0";
    }

    public void reloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
