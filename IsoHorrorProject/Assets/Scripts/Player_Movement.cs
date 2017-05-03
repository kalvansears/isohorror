using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Player_Movement : MonoBehaviour {

    KeyCode keyUp = KeyCode.A;
    KeyCode keyLeft = KeyCode.S;
    KeyCode keyDown = KeyCode.D;
    KeyCode keyRight = KeyCode.W;

   

    public float speed = .5f;





	
	// Update is called once per frame
	void Update () {

    

        if (Input.GetKey(keyUp))
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(keyDown))
        {
            transform.Translate(-transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(keyLeft))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(keyRight))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

		
	}
}
