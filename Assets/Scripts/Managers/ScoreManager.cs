using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //A static variable just means there should only be one type of this script
    //also refereed to as the instance of said script
    public static ScoreManager Instance;

    public int Score { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    //The equation within the function can be written out as; current "Score" + amount = new "Score"
    //Whilst Score is the same name on both sides of the equation they are the before and after versions.
    public void AddScore(int amount)
    {
        Score += amount;
    }

    public void ResetScore()
    {
        Score = 0;
    }
}
