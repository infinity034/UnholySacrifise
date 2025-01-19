using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

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

    private void Start()
    {
        playerControls.Player.Movement.started += ctx => StartMove(ctx);
        playerControls.Player.Movement.canceled += ctx => StopMove(ctx);
    }

    private void StartMove(InputAction.CallbackContext ctx)
    {
        switch (playerControls.Player.Movement.ReadValue<Vector2>())
        {
            case Vector2 v when v.Equals(Vector2.up):
                Debug.Log("W");
                break;
            case Vector2 v when v.Equals(Vector2.down):
                Debug.Log("S");
                break;
            case Vector2 v when v.Equals(Vector2.left):
                Debug.Log("A");
                break;
            case Vector2 v when v.Equals(Vector2.right):
                Debug.Log("D");
                break;
            default:
                break;
        }
    }

    private void StopMove(InputAction.CallbackContext ctx)
    {
        
    }
}
