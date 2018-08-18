using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    // Movement speed
    public float speed = 2;
    
    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start ()
    {    
        // Fly towards the right
        ///GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    
    // Update is called once per frame
    void Update ()
    {
        // Flap
        if (Input.touchCount > 0 || Input.GetButton("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().Sleep();
            GetComponent<Rigidbody2D>().WakeUp();
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            }
          
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        // Restart
        Application.LoadLevel("end");
    }
}
