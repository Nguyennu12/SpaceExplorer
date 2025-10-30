using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    
    public float minSpeed = 2f;

    
    public float maxSpeed = 5f;

    
    private Rigidbody2D rb;

    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

        
        float randomSpeed = Random.Range(minSpeed, maxSpeed);

        
        rb.linearVelocity = Vector2.left * randomSpeed;
    }
}