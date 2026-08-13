using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int bossHealth;
    public GameObject[] bossHealthAttackLocation;
    public GameObject healthPickUp;

    public GameObject gameWinScreen;
    public bool gameRunning = true;

    public float nextSpawnTime;
    public float minSpawnTime;
    public float maxSpawnTime;

    public int lastSpawnIndex = -1;

    private void Start()
    {
        gameWinScreen.SetActive(false);
    }

    void Update()
    {
        nextSpawnTime -= Time.deltaTime;

        if (nextSpawnTime <= 0f && gameRunning)
        {
            BossHealthSpawn();

            nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }

        if(bossHealth <= 0)
        {
            gameWinScreen.SetActive(true);
            gameObject.GetComponent<BossFightManager>().enabled = false;
            gameRunning = false;
        }
    }

    public void TakeDamage(int damage)
    {
        bossHealth += damage;
    }

    private void BossHealthSpawn()
    {
        int randomIndex = Random.Range(0, bossHealthAttackLocation.Length);

        while (randomIndex == lastSpawnIndex)
        {
            randomIndex = Random.Range(0, bossHealthAttackLocation.Length);
            Debug.Log("randomIndex was the same");
        }
        Instantiate(healthPickUp, bossHealthAttackLocation[randomIndex].gameObject.transform.position, Quaternion.identity);

        lastSpawnIndex = randomIndex;
    }
}