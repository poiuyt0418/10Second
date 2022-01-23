using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    Vector3 direction = new Vector3(0,0,0);
    public ParticleSystem ps;

    void Start()
    {
        transform.rotation = transform.parent.GetComponent<Gun>().crossbow.transform.rotation;
        direction = transform.parent.GetComponent<Gun>().firePoint.transform.position-transform.parent.GetComponent<Gun>().crossbow.transform.position;
    }

    void Update()
    {
        transform.position += (direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(collision.gameObject);
        Destroy(gameObject);
        //someObject.points += transform.parent.transform.parent.charge + 1;
        transform.parent.transform.parent.GetComponent<createGun>().shatter.Play(0);
        Instantiate(ps, transform.position, transform.rotation);
    }
}