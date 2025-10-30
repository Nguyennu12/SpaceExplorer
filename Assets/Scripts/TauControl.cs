using UnityEngine;
using UnityEngine.InputSystem;

public class TauControl : MonoBehaviour
{
    public GameObject laserPrefab;  
    public Transform firePoint;      
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleInput();
        HandleShooting();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleInput()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        moveInput = Vector2.zero;

       
        if (keyboard.upArrowKey.isPressed)
        {
            moveInput.y = 1;
        }
       
        else if (keyboard.downArrowKey.isPressed)
        {
            moveInput.y = -1;
        }
    }

    void HandleMovement()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveInput.y * moveSpeed);
    }

    // Inside TauControl class
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Star"))
        {
            FindAnyObjectByType<GameManager>().AddScore(10);
            Destroy(other.gameObject); // Remove the star
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // When colliding with "Asteroid"
        if (other.gameObject.CompareTag("Asteroid"))
        {
            FindAnyObjectByType<GameManager>().GameOver(); // End the game
            Destroy(this.gameObject); // Destroy the ship
        }
    }
    void HandleShooting()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

       
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }
    void Shoot()
    {

        Instantiate(laserPrefab, firePoint.position, laserPrefab.transform.rotation);
    }
}