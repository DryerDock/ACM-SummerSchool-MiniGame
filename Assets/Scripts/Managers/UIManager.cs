using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gameOverPanel;

    private void Update()
    {
        scoreText.text = ScoreManager.Instance.Score.ToString();

        gameOverPanel.SetActive(!GameManager.Instance.GameIsRunning);
    }
}