using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update() {
        //experimenting with directional shooting
        //shoot right
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject go = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Bullet>().xSpeed = 1f;
        }
        //shoot left
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject go = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Bullet>().xSpeed = -1f;
        }
        //shoot up
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject go = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Bullet>().ySpeed = 1f;
        }
        //shoot down
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject go = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Bullet>().ySpeed = -1f;
        }

    }

    void Shoot() {
        //shooting logic, to spawn bullet after Fire1 is pressed (not moving)
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
