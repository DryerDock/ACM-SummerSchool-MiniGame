using UnityEngine;

public class PlayerHealthBossFight : MonoBehaviour
{
    public BossHealth bossHealthManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BossPickUp"))
        {
            bossHealthManager.TakeDamage(-1);
            Destroy(other.gameObject);
        }
    }
}
