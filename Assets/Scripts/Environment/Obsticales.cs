using UnityEngine;
//For students to see
public class Obsticales : MonoBehaviour
{
    //We compare the collider on the other object in this case the player object
    //if it is true we call the GameOver function in the GameManager script
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
