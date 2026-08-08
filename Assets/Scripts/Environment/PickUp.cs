using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public int scoreValue = 10;

    //We compare the collider on the other object in this case the player object
    //if it is true we call the AddScore function in the ScoreManager script and then Destroy this gameObject
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(scoreValue);

            Destroy(gameObject);
        }
    }
}
