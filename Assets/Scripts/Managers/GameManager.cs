using UnityEngine;
using UnityEngine.SceneManagement;
//For students to see
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool GameIsRunning;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        Time.timeScale = 1.0f;
        GameIsRunning = true;
    }

    public void GameOver()
    {
        GameIsRunning = false;
        Time.timeScale = 0.0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}