using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float jumpHeight = 0.5f;
    public float g = 9;
    public float airControl = 0.5f;
    public float maxFallSpeed = 1;

    CharacterController characterController;

    float inputX, inputZ;

    Vector3 moveVelocity;

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
        moveVelocity.x = movement.x * moveSpeed;
        moveVelocity.z = movement.z * moveSpeed;
        if (characterController.isGrounded && Input.GetKey(KeyCode.Space))
        {
            moveVelocity.y = Mathf.Sqrt(jumpHeight * 2f * g);
        }
        moveVelocity.y -= g*Time.deltaTime;
        //
        moveVelocity.y = Mathf.Clamp(moveVelocity.y, -maxFallSpeed, Mathf.Infinity);
        characterController.Move(moveVelocity * Time.deltaTime);
    }
}
