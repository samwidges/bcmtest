using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitcoinbullet : MonoBehaviour {

    public bool shouldMove;

    public Vector2 velocity;

    public LayerMask coinMask;


    public bool hit = false;

    public int pointsToDeduct;

	// Use this for initialization
	void Start () {
		
        bitCoinScoreManager.DeductPoints(pointsToDeduct);
	}
	
	// Update is called once per frame
	void Update () {

       

        Vector3 pos = transform.localPosition;

        pos = CheckCoins(pos);

        if(shouldMove){

            pos.y += velocity.y * Time.deltaTime;
            transform.localPosition = pos;

        }
		

	}

    Vector3 CheckCoins(Vector3 pos)
    {



        Vector2 originMiddleDown = new Vector2(pos.x, pos.y + 0.1f);



        RaycastHit2D down = Physics2D.Raycast(originMiddleDown, Vector2.up, 0.24f, coinMask);


        if (down.collider != null)
        {

            RaycastHit2D hitRay = down;

            if (down)
            {
                hitRay = down;
            }

            if (hitRay.collider.tag == "BitCoin" && !hit)
            {
                hit = true;

                hitRay.collider.GetComponent<BitCoin>().Hit();

                bitCoinScoreManager.DeductPoints(pointsToDeduct);
                Destroy(this.gameObject);

            }

           
        }

        return pos;


    }

    void OnBecameInvisible()
    {
        
        Destroy(this.gameObject);
    }
}
