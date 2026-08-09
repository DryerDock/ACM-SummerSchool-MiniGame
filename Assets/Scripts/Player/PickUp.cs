using UnityEngine;
/// <summary>
/// For students to see and edit
/// </summary>
public class PickUp : MonoBehaviour
{
    public int scoreValue = 10;

    //We compare the collider on the other object in this case the pickup object
    //if it is true we call the AddScore function in the ScoreManager script and then Destroy the other gameObject
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PickUp"))
        {
            ScoreManager.Instance.AddScore(scoreValue);

            Destroy(other.gameObject);
        }
    }
}
