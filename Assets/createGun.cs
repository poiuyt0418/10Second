using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class createGun : MonoBehaviour
{
    public KeyCode key;
    public GameObject crossbow;
    public TMP_Text text;
    public GameObject sprite;
    bool gunControl = false;
    GameObject gun;
    public GameObject bulletPrefab;
    public int startAngle;
    float charge;
    float startTime = 0;
    public AudioSource shatter;

    void Start()
    {
        gun = Instantiate(crossbow, transform.position, Quaternion.Euler(0, 0, startAngle), transform);
        charge = 0;
    }

    void Update()
    {
        charge = .8f*(int)Mathf.Floor(Time.time - startTime)+.2f;
        if (Input.GetKeyDown(key) && gunControl == false)
        {
            sprite.SetActive(false);
            text.enabled = false;
            gunControl = true;
            startTime = Time.time;
        }
        if (Input.GetKeyUp(key))
        {
            GameObject bullet = Instantiate(bulletPrefab, gun.GetComponent<Gun>().firePoint.transform.position, gun.transform.rotation, gun.transform);
            Destroy(bullet, (charge<1?.5f:charge));
            Debug.Log(charge);
            charge = 0;
            sprite.SetActive(true);
            gunControl = false;
            text.enabled = true;
        }
    }
}
