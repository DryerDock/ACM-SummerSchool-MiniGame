using System.Collections;
using UnityEngine;

public class BossFightManager : MonoBehaviour
{

    public GameObject[] bossSlamPositions;
    public GameObject[] bossAttacks;

    public float nextAttackTime;
    public float minAttackTime;
    public float maxAttackTime;

    public int lastAttackIndex = -1;

    void Update()
    {
        nextAttackTime -= Time.deltaTime;

        if (nextAttackTime <= 0f)
        {
            BossAttackSpawn();

            nextAttackTime = Random.Range(minAttackTime, maxAttackTime);
        }
    }

    private void BossAttackSpawn()
    {
        int randomIndex = Random.Range(0, bossSlamPositions.Length);

        while (randomIndex == lastAttackIndex)
        {
            randomIndex = Random.Range(0, bossSlamPositions.Length);
            Debug.Log("randomIndex was the same");
        }

        switch (randomIndex)
        {
            case 0:
                Instantiate(bossAttacks[0], bossSlamPositions[randomIndex].gameObject.transform.position, Quaternion.identity);
                break;

            case 1:
                Instantiate(bossAttacks[1], bossSlamPositions[randomIndex].gameObject.transform.position, Quaternion.identity);
                break;

            case 2:
                Instantiate(bossAttacks[2], bossSlamPositions[randomIndex].gameObject.transform.position, Quaternion.identity);
                break;

            default:
                Debug.Log("Fallen Outside of Switch");
                Instantiate(bossAttacks[0], bossSlamPositions[0].gameObject.transform.position, Quaternion.identity);
                break;
        }

        lastAttackIndex = randomIndex;
    }
}