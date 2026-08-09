using UnityEngine;
using TMPro;
//For students to see
public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text endScoreText;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = ScoreManager.Instance.Score.ToString();

        if(GameManager.Instance.GameIsRunning == false)
        {
            gameOverPanel.SetActive(true);
            endScoreText.text = "Score " + ScoreManager.Instance.Score.ToString();
            scoreText.gameObject.SetActive(false);
        }
    }
}