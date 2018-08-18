using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo : MonoBehaviour {
    public bool active;
    public float steprotation, stepmove, total, totalmove;
    private float elapsed,elapsedmove;
    private bool direction;
	// Use this for initialization
	void Start ()
    {
        active = false;
        direction = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        elapsed += Time.deltaTime;
        if (!active)
        {
            elapsedmove += Time.deltaTime;
            if (elapsedmove > totalmove)
            {
                active = true;
            }
        }
        
        if(elapsed >= total)
        {
            elapsed = 0;
            direction = !direction;
        }
    
        if (active)
        {
            if (direction)
            {
                GetComponent<Transform>().Rotate(new Vector3(0, 0, steprotation));
            }
            else
            {
                GetComponent<Transform>().Rotate(new Vector3(0, 0, -steprotation));
            }

        }
        else
        {
            GetComponent<Transform>().Translate(new Vector3(0, stepmove, 0));
        }
	}
}
