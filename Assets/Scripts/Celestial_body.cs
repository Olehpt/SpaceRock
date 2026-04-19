using UnityEngine;
public class Celestial_body : MonoBehaviour
{
    public float mass;
    public Vector3 initVelocity;
    public Celestial_body parent;
    Rigidbody rb;
    Vector3 gForce;
    private void Start()
    {
        if (parent == null) enabled = false;
        rb = GetComponent<Rigidbody>();
        //overrides rigidbody props
        if (rb != null)
        {
            rb.mass = mass;
            rb.useGravity = false;
            rb.linearVelocity = initVelocity;
        }
    }
    void FixedUpdate()
    {
        Vector3 vec = parent.transform.position - transform.position;
        float r = vec.magnitude;
        float F = 6.6f * parent.mass * mass / (r * r);
        gForce = vec.normalized * F;
        //
        rb.AddForce(gForce, ForceMode.Force);
    }
}
