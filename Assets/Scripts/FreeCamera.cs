using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public float sensX, sensY;
    float rotationX, rotationY, inputX, inputZ;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        //
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
        //
        transform.position += transform.right * inputX * moveSpeed * Time.deltaTime;
        transform.position += transform.forward * inputZ * moveSpeed * Time.deltaTime;
    }
}
