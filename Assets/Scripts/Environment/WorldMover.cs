using UnityEngine;
//For students to see
public class WorldMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyX;

    //Every frame we move anything that has this script attached to it by the result of the calculation,
    //I.E Vector2.left = (-1, 0) * 5 * the time between the last frame and the current frame being calculated(roughly 0.002ms)
    //Written out it would look like this:  -1 * 5 = -5, then, -5 * 0.002 = -0.01
    private void Update()
    {
        float speed = moveSpeed;

/*      DifficultyManager difficulty = FindFirstObjectByType<DifficultyManager>();

        if (difficulty != null)
        {
            speed = difficulty.CurrentSpeed;
        }*/
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}