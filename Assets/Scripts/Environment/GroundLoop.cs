using UnityEngine;
//For students to see
public class GroundLoop : MonoBehaviour
{
    public float resetX;
    public float moveToX;

    private void Update()
    {
        if (transform.position.x < resetX)
        {
            transform.position = new Vector3(moveToX, transform.position.y, transform.position.z);
        }
    }
}
