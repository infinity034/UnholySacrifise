using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Vector2 movement;

    public float speed;

    private void Awake()
    {
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
            transform.rotation = Quaternion.Euler(0,0,angle - 90f);
        }
    }
}
