using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //If the player presses the spacebar and isGrounded is set to true.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    //Current velocity is equal to the current x velocity multiplied by the jumpForce
    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        isGrounded = false;
    }

    //We compare against the "Ground" tag to ensure we are grounded so we don't have the ability to jump constantly
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}