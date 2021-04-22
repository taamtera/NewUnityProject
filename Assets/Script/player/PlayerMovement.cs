using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 1000f;
    public Rigidbody rB;
    void FixedUpdate()
    {
        float forcetime = force * Time.deltaTime;
        if (Input.GetKey("w"))
        {
            rB.AddForce(0, 0, forcetime);
        }
        if (Input.GetKey("s"))
        {
            rB.AddForce(0, 0, -forcetime);
        }
        if (Input.GetKey("d"))
        {
            rB.AddForce(forcetime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rB.AddForce(-forcetime, 0, 0);
        }

         //Get the Screen positions of the object
         Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
         
         //Get the Screen position of the mouse
         Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
         
         //Get the angle between the points
         float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
         //Ta Daaa
         transform.rotation = Quaternion.Euler (new Vector3(0f, -angle, 0f));

    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}