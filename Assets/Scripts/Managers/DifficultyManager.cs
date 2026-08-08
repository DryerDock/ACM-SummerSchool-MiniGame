using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public float startingSpeed = 5f;
    public float speedIncrease = 0.1f;

    public float CurrentSpeed { get; private set; }

    private void Start()
    {
        CurrentSpeed = startingSpeed;
    }

    private void Update()
    {
        CurrentSpeed += speedIncrease * Time.deltaTime;
    }
}
