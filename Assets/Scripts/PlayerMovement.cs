using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private CharacterController characterController;
    private float verticalVelocity;
    private float gravity = -9.81f;
    private void Update()
    {
        Vector2 moveInput = ReadMovementInput();

        HandleAttack();

        HandleJump();

        Move(moveInput);
    }

    private void Move(Vector2 moveInput)
    {
        if (characterController.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        // Laske pelaajan liikumista
        Vector3 direction = transform.right * moveInput.x + transform.forward * moveInput.y;

        Vector3 velocity = direction * moveSpeed + Vector3.up * verticalVelocity;

        characterController.Move(velocity * Time.deltaTime);
    }

    Vector2 ReadMovementInput()
    {
        // Alusta liikesyöte nollaksi
        Vector2 moveInput = Vector2.zero;

        // GAMEPAD: Tarkista onko peliohjain kytkettynä
        if (Gamepad.current != null)
        {
            moveInput = Gamepad.current.leftStick.ReadValue();
        }

        if (Keyboard.current != null)
        {
            float x = 0f;
            float y = 0f;


            if (Keyboard.current.aKey.isPressed) x -= 1f;
            if (Keyboard.current.dKey.isPressed) x += 1f;
            if (Keyboard.current.wKey.isPressed) y -= 1f;
            if (Keyboard.current.sKey.isPressed) y += 1f;

            if(x != 0f || y != 0f) moveInput = new Vector2(x, y).normalized;    
        }

        // Palauta liikesyöte kutsujalle
        return moveInput;
    }

    void HandleAttack()
    {
        if (Gamepad.current == null)
            return;

        if (Gamepad.current.rightTrigger.wasPressedThisFrame)
        {
            Debug.Log("Hyökkäys aktivoitu");
        }
    }
    void HandleJump()
    {
        if (Gamepad.current == null) return;

        if (Gamepad.current.buttonSouth.wasPressedThisFrame && characterController.isGrounded)
        {
            verticalVelocity = 5f;
        }
    }
}
