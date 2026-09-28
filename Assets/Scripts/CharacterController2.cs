using UnityEditor.Callbacks;
using UnityEngine;

public class CharacterController2 : MonoBehaviour
{
    private float jumpStrength = 5f;
    private float movementSpeed = 5f;

    private Vector2 movement = Vector2.zero;
    
    private Rigidbody2D rb;

    public Transform groundCheck;
    public LayerMask groundLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpStrength);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * -movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
    }
}
