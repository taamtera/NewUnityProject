using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 10000f;
    public float lifeTime = 1f;
    public Rigidbody rB;

    void Start()
    {
        rB.AddForce(rB.transform.forward * speed);
    }
    void Awake() { Destroy(gameObject, lifeTime); }
}
