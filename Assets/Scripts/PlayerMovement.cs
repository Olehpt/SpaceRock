using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float jumpHeight = 0.5f;
    public float g = 9;
    public float airControl = 0.5f;
    public float maxFallSpeed = 50;
    public float sprintSpeedMultiplier = 2f;

    CharacterController characterController;

    float inputX, inputZ;

    Vector3 moveVelocity;
    float TimeFalling;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 movement = transform.right * inputX + transform.forward * inputZ;
        movement.Normalize();

        moveVelocity.x = movement.x * moveSpeed;
        moveVelocity.z = movement.z * moveSpeed;

        moveVelocity.y -= g * Time.deltaTime;
        if (characterController.isGrounded) moveVelocity.y = 0;

        if (characterController.isGrounded && Input.GetKey(KeyCode.Space))
        {
            moveVelocity.y = Mathf.Sqrt(jumpHeight * 2f * g);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveVelocity.x *= sprintSpeedMultiplier;
            moveVelocity.z *= sprintSpeedMultiplier;
        }

        moveVelocity.y = Mathf.Clamp(moveVelocity.y, -maxFallSpeed, Mathf.Infinity);
        characterController.Move(moveVelocity*Time.deltaTime);
    }
    public Vector3 getMoveVelocity()
    {
        return moveVelocity;
    }
}
