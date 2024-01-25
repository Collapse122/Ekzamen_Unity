using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{

    public Transform slingShot;
    public float springRange;
    public float maxVel;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    bool canDrag = true;
    Vector3 dis;

    void OnMouseDrag()
    {
        if (!canDrag)
        {
            return;
        }

        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dis = pos - slingShot.position;
        dis.z = 0;

        if(dis.magnitude > springRange)
        {
            dis = dis.normalized * springRange;
        }
        transform.position = dis + slingShot.position;
    }

    void OnMouseUp()
    {
        if (!canDrag)
        {
            return;
        }
        canDrag = false;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = -dis.normalized * maxVel * dis.magnitude / springRange;
    }
}
