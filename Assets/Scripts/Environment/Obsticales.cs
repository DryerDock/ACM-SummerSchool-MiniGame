using UnityEngine;

public class Obsticales : MonoBehaviour
{
    //We compare the collider on the other object in this case the player object
    //if it is true we call the GameOver function in the GameManager script
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
