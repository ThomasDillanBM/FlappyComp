using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuvem : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 10f);
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
