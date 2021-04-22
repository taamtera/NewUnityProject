using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Sphere;
    public Transform Spawn;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Sphere, Spawn.position, Spawn.rotation);
            //Debug.Log("fire" + Spawn.position + Spawn.rotation);
        }
    }
}
