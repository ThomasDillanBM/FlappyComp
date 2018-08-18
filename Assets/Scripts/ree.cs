using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ree : MonoBehaviour {

    public float totalTime;
    private float elpased;
    private bool ok;
	// Use this for initialization
	void Start () {
        elpased = 0;
        ok = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!ok)
        elpased += Time.deltaTime;
        if (elpased >= totalTime)
        {
            ok = true;
        }
        if (Input.touchCount > 0 && ok)
        {
            Application.LoadLevel("new");
        }
    }
}
