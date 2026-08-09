using UnityEngine;
//For students to see
public class ObsticaleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform spawnPoint;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    private float spawnTimer;

    //Here we use the update function to countdown from a random number between the min and maxSpawnTime
    //Once the spawnTimer is less than or equal to 0 we then spawn a new obstacle and choose a new random time to countdown from
    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnObstacle();

            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    //We create a random number between 0 and the total of different obstacles we have within the list of game objects.
    private void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}