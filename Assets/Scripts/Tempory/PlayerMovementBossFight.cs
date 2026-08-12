using UnityEngine;

public class PlayerMovementBossFight : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;

    public bool isGrounded;

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

        if (JumpPressed() && isGrounded)
        {
            Jump();
        }
    }
    private bool JumpPressed()
    {
        bool keyboard = Input.GetKeyDown(KeyCode.Space);
        keyboard |= Input.GetKeyDown(KeyCode.UpArrow);
        keyboard |= Input.GetKeyDown(KeyCode.W);

        bool mouse = Input.GetMouseButtonDown(0);
        bool touch = Input.touchCount > 0 &&
                     Input.GetTouch(0).phase == TouchPhase.Began;

        return keyboard || mouse || touch;
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}