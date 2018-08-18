using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resp : MonoBehaviour {
    public GameObject objeto;
    //Time to respawn the fireball
    public float respawnTime = 0f;
    //elapsed time to last fireball
    private float elapsedTime = 0f;
    public Transform[] points;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= respawnTime)
        {
            int index = Random.Range(0, points.Length-1);
            Instantiate(objeto, points[index].position, points[index].rotation);
            elapsedTime = 0f;
        }
    }
}
