using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private float speed;

    public GameObject bullet;
    public Transform shotspawn;

    void Start()
    {
        speed = 20f;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            shoot();
            
            
    }
    void shoot()
    {
        GameObject g = Instantiate(bullet, shotspawn.position, shotspawn.rotation) as GameObject;
        Destroy(g, 1.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
