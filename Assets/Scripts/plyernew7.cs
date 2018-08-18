using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyernew7 : MonoBehaviour
{

    // Movement speed
    public float speed = 2;

    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        ///GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
     

    }

   public void jump()
    {
        GetComponent<Rigidbody2D>().Sleep();
        GetComponent<Rigidbody2D>().WakeUp();
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
}
