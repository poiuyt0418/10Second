using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Rigidbody2D rb;
    bool rotateUp;
    public GameObject firePoint;
    public GameObject crossbow;

    // Start is called before the first frame update
    void Start()
    {
        rb = crossbow.GetComponent<Rigidbody2D>();
        rotateUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.rotation % 360 >= transform.parent.GetComponent<createGun>().startAngle)
        {
            rotateUp = false;
        }
        else if (rb.rotation % 360 <= transform.parent.GetComponent<createGun>().startAngle - 90)
        {
            rotateUp = true;
        }
        if (rotateUp)
        {
            rb.MoveRotation(rb.rotation + 50.0f * Time.fixedDeltaTime);
        }
        else
        {
            rb.MoveRotation(rb.rotation + -50.0f * Time.fixedDeltaTime);
        }
    }
}
