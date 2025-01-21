using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    private PlayerControls playerControls;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Transform body;

    [SerializeField]
    private Vector2 movement;

    public float speed;
    public PlayerControls PlayerControls { get { return playerControls; } }

    private void Awake()
    {
        Instance = this;
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void FixedUpdate()
    {
        StartMovement();
    }

    private void StartMovement()
    {
        movement.Set(playerControls.Player.Movement.ReadValue<Vector2>().x, playerControls.Player.Movement.ReadValue<Vector2>().y);
        rb.velocity = movement * speed;

        if(movement != Vector2.zero)
        {
            float angle = Mathf.Atan2 (movement.y,movement.x) * Mathf.Rad2Deg;
            body.rotation = Quaternion.Euler(0,0,angle - 90f);
        }
    }
}
