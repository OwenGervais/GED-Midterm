using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField] private float speed = 10f;

    [SerializeField] private float jump = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float focusSpeed = Input.GetKey(KeyCode.LeftShift) ? 0.5f : 1f;

        Vector3 movement = new Vector3(horizontal, 0f, 0f);

        movement.Normalize();

        movement = new Vector3(movement.x * speed * focusSpeed, movement.y * speed * focusSpeed, 0f);

        rb.linearVelocity = movement;

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }
}
