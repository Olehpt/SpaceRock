using UnityEngine;

public class OrbitTest : MonoBehaviour
{
    public Transform focus;
    public float offset = 0f;

    Vector3 center;
    float a, b;
    void Start()
    {
        if (focus == null) enabled = false;
        //
        Vector3 vec = focus.transform.position - transform.position;
        center = transform.position + vec.normalized * (vec.magnitude + offset);
        a = (center - transform.position).magnitude;
        float c = (center - focus.position).magnitude;
        b = Mathf.Sqrt(a * a - c * c);
        //debug
        Debug.Log($"a: {a}, b: {b}, center: {center}, c: {c}");
    }
    void FixedUpdate()
    {
        float x = a * Mathf.Cos(Time.time*0.2f);
        float z = b * Mathf.Sin(Time.time*0.2f);
        transform.position = center + new Vector3(x, 0, z);
        //debug
        Debug.Log($"x: {x}, z: {z}");
    }
}
