using UnityEngine;
public class RayCaster : MonoBehaviour
{
    public float distance = 3f;
    public LayerMask interactLayer;
    private IIntractable currentObject = null;
    public UImanager uiManager;
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, interactLayer))
        {
            var interactable = hit.collider.GetComponent<IIntractable>();
            if (interactable != currentObject)
            {
                Debug.Log("Raycaster looks at interactable object");
                currentObject = interactable;

                uiManager.ShowHint();
            }
            if (Input.GetKey(KeyCode.E))
            {
                interactable.Interact();
            }
        }
        else
        {
            currentObject = null;
            uiManager.HideHint();
        }
    }
}
