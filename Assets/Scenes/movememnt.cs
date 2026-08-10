using UnityEngine;

public class movememnt : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);
        }
    }
}