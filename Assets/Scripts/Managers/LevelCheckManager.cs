using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCheckManager : MonoBehaviour
{
    public float scoreToProgress;
    public void Update()
    {
        if(ScoreManager.Instance.Score >= scoreToProgress)
        {
            SceneManager.LoadScene("BossFight");
        }
    }
}
