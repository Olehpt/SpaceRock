using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform focus;
    public float offset = 0f;

    Vector3 center;
    float a, b, angle;
    void Start()
    {
        if (focus == null) enabled = false;
        center = focus.transform.position;
        a = (center - transform.position).magnitude;
        float c = (center - focus.position).magnitude;
        b = Mathf.Sqrt(a * a - c * c);
        //
        Vector3 centerVec = transform.position - center;
        angle = Mathf.Atan2(centerVec.z / b, centerVec.x / a);

    }
    void FixedUpdate()
    {
        center = focus.transform.position;
        //
        float x = a * Mathf.Cos(Time.time*1f + angle);
        float z = b * Mathf.Sin(Time.time*1f + angle);
        transform.position = center + new Vector3(x, 0, z);
    }
}
