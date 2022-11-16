using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    public Text scoreTextInGameOverPanel;

    public void SetScore(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); 
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ShowGameOverPanel(bool isShow, int score)
    {
        if (scoreTextInGameOverPanel != null)
        {
            scoreTextInGameOverPanel.text = "Your score: " + score.ToString();
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(isShow);
        }
    }
}
