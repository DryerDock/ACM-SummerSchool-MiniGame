using UnityEngine;

public class ScoreOverTime : MonoBehaviour
{
    public float pointsPerSecond = 1f;

    private float timer;

    //Here we make the timer equal to the difference between frames
    //We then add one point to the score every time the timer is greater than 1 second between the total frames,
    //reseting it back to 0 once we have added the score
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            ScoreManager.Instance.AddScore(1);
            timer = 0f;
        }
    }
}
