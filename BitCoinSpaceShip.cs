using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitCoinSpaceShip : MonoBehaviour {

    public Transform shootPoint;

    public Vector2 velocity;

    public GameObject bullet;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.localPosition;
		
        if(Input.GetButton("Left") && transform.position.x >= -8){

            pos.x -= velocity.x * Time.deltaTime;
            transform.localPosition = pos;
        }

        if (Input.GetButton("Right") && transform.position.x <= 8)
        {

            pos.x += velocity.x * Time.deltaTime;
            transform.localPosition = pos;
        }

        if(Input.GetButtonDown("Jump")){

            Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation);

        }
	}
}
