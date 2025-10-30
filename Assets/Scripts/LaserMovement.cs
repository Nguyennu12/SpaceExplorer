using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float speed = 20f; 
    private Rigidbody2D rb;   // Rigidbody reference

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();


        rb.linearVelocity = Vector2.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
        if (hitInfo.CompareTag("Asteroid"))
        {
            Destroy(hitInfo.gameObject);
            Destroy(gameObject);         
        }
    }
}
