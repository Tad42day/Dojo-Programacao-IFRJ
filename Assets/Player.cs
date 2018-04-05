using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float minY, maxY, minX, maxX;
    float gravity = 0.4f;
    Vector2 speed;
    public bool onFloor; 

	// Use this for initialization
	void Start () {
         
	}
	
	// Update is called once per frame
	void Update () {
        minX = GetComponent<SpriteRenderer>().sprite.bounds.min.x;
        maxY = GetComponent<SpriteRenderer>().sprite.bounds.max.y;
        maxX = GetComponent<SpriteRenderer>().sprite.bounds.max.x;
        minY = GetComponent<SpriteRenderer>().sprite.bounds.min.y;

        if (!onFloor)
        {
            speed.y -= gravity;
        }

        transform.position = new Vector3(Input.GetAxisRaw("Horizontal") * speed.x, speed.y);
		


	}
}
