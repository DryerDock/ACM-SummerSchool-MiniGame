using UnityEngine;

public class ObjectCleanUp : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 7f);
    }
}