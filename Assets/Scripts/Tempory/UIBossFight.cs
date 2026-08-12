using UnityEngine;

public class UIBossFight : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(false);
    }
    public void Update()
    {
        if (GameManager.Instance.GameIsRunning == false)
        {
            gameOverPanel.SetActive(true);        
        }
    }
}