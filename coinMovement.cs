using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMovement : MonoBehaviour {

    public bool shouldMove;

    public bool shouldMoveLeft;

    public bool isMovingLeft = false;

    public bool shouldMoveRight;

    public bool isMovingRight;

    public float moveSpeed;

    public float maxLeftPosition;

    public float maxRightPosition;

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        
         
        if(shouldMoveLeft & !isMovingLeft){

            isMovingLeft = true;
            StartCoroutine("MoveLeft");

        }

        if(transform.position.x <= maxLeftPosition ){

            isMovingLeft = false;
            shouldMoveLeft = false;
            StopCoroutine("MoveLeft");
            shouldMoveRight = true;

        }

        if(shouldMoveRight & !isMovingRight){


            isMovingRight = true;
            StartCoroutine("MoveRight");

        }

        if (transform.position.x >= maxRightPosition)
        {

            isMovingRight = false;
            shouldMoveRight = false;
            StopCoroutine("MoveRight");
            shouldMoveLeft = true;

        }


        }
		
	

    public IEnumerator MoveLeft(){

        while(true){
        transform.position = new Vector2(transform.position.x - 0.0625f, transform.position.y);
            yield return new WaitForSeconds(moveSpeed);

        }
    }

    public IEnumerator MoveRight()
    {

        while (true)
        {
            transform.position = new Vector2(transform.position.x + 0.0625f, transform.position.y);
            yield return new WaitForSeconds(moveSpeed);

        }
    }
}
