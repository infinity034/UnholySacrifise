using System;
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
        playerControls.Player.Slot0.performed += ctx => SlotAction(ctx, 0);
        playerControls.Player.Slot1.performed += ctx => SlotAction(ctx, 1);
        playerControls.Player.Slot2.performed += ctx => SlotAction(ctx, 2);
        playerControls.Player.Slot3.performed += ctx => SlotAction(ctx, 3);
        playerControls.Player.Slot4.performed += ctx => SlotAction(ctx, 4);
        playerControls.Player.Slot2.performed += ctx => SlotAction(ctx, 5);
        playerControls.Player.Slot3.performed += ctx => SlotAction(ctx, 6);
        playerControls.Player.Slot4.performed += ctx => SlotAction(ctx, 7);
    }

    private void OnDisable()
    {
        playerControls.Disable();
        playerControls.Player.Slot0.performed -= ctx => SlotAction(ctx, 0);
        playerControls.Player.Slot1.performed -= ctx => SlotAction(ctx, 1);
        playerControls.Player.Slot2.performed -= ctx => SlotAction(ctx, 2);
        playerControls.Player.Slot3.performed -= ctx => SlotAction(ctx, 3);
        playerControls.Player.Slot4.performed -= ctx => SlotAction(ctx, 4);
        playerControls.Player.Slot2.performed -= ctx => SlotAction(ctx, 5);
        playerControls.Player.Slot3.performed -= ctx => SlotAction(ctx, 6);
        playerControls.Player.Slot4.performed -= ctx => SlotAction(ctx, 7);
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

    private void SlotAction(InputAction.CallbackContext ctx, int v)
    {
        Inventory.Instance.Slots[v].UseItem();
    }
}
