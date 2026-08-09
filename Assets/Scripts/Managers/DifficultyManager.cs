using UnityEngine;
//For students to see
public class DifficultyManager : MonoBehaviour
{
    public float startingSpeed = 5f;
    public float maximumSpeed = 12f;
    public float speedIncreasePerSecond = 0.15f;

    public float CurrentSpeed { get; private set; }

    private void Start()
    {
        CurrentSpeed = startingSpeed;
    }

    private void Update()
    {
        if (GameManager.Instance == null || !GameManager.Instance.GameIsRunning)
        {
            return;
        }

        CurrentSpeed += speedIncreasePerSecond * Time.deltaTime;
        CurrentSpeed = Mathf.Min(CurrentSpeed, maximumSpeed);
    }
}