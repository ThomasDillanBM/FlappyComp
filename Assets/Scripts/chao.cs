using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour {

 
    public float scrollSpeed = 0.5F;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update ()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, -0.08f));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Application.LoadLevel("end");
        }
    }
}
