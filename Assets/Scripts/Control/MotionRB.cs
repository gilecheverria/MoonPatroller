/*
Moving an object using a rigid body 2D

Gil Echeverria
14/09/2020
*/

using UnityEngine;

public class MotionRB : MonoBehaviour
{
    public float speed;
    public Vector3 jumpForce;

    bool grounded = false;
    bool facingRight = true;

    Vector3 motion;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
        JumpControl();
        rb.velocity = motion;
    }

    void MoveControl()
    {
        // Change horizontan movement only when grounded
        if (grounded)
        {
            motion.x = Input.GetAxis("Horizontal") * speed;
        }
        motion.y = rb.velocity.y;

        // Turn the object around depending on the direction of travel
        if (motion.x > 0 && !facingRight)
        {
            facingRight = true;
            transform.Rotate(0, 180, 0);
        }
        if (motion.x < 0 && facingRight)
        {
            facingRight = false;
            transform.Rotate(0, 180, 0);
        }
    }

    void JumpControl()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(jumpForce);
            grounded = false;
        }

        // Interrupt a jump when the button is released
        if (Input.GetButtonUp("Jump") && !grounded)
        {
            if (rb.velocity.y > 0)
            {
                motion.y /= 2;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}