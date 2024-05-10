using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    public float WaterDensity = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Destroy(gameObject,10);
    }

    private void FixedUpdate()
    {
        float divePercent = -transform.position.y + transform.localScale.x * 0.5f;
        divePercent = Mathf.Clamp(divePercent, 0f, 1f);

        rb.AddForce(Vector3.up * divePercent * WaterDensity);
        rb.drag = divePercent * 2f;
        rb.angularDrag = divePercent * 2f;
    }
 
}
