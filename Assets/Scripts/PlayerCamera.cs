using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensX, sensY;

    public Transform player;

    float rotationX, rotationY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
    }
    private void FixedUpdate()
    {
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        player.localRotation = Quaternion.Euler(0, rotationY, 0);
    }
}
