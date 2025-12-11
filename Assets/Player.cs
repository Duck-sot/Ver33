using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private bool grounded = true; 
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = 12f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -12f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if(grounded)
            {
                rb.linearVelocityY = 16f;
                grounded = false; 
            }
        }
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            grounded = true; 
        }
        
    }
}
 