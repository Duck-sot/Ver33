using UnityEngine;

public class ArB : MonoBehaviour
{
 private Vector3 mousePos;
    private Camera mainCam; 
    private Rigidbody2D rb;
    private float force = 40f; 
    private int dmg = 8; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GameObject.FindAnyObjectByType<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos; 
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force; 
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; 
        transform.rotation = Quaternion.Euler(0, 0, rot +90);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("här");
        if(collision.collider.tag == "ground" || collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            print("destroying");
        }
    }
}
