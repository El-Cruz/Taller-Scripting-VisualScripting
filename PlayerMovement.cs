using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Configuración de Velocidad")]
    [SerializeField] private float speed = 6f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        
        rb.linearVelocity = moveInput * speed;
    }
}
