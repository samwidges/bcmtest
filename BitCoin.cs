using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitCoin : MonoBehaviour
{

    public int health;

    public GameObject coinDeath;

    public bool mined;

    public int pointsToGive;

    public AudioClip coinHit1;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {


        if(health == 3){

            GetComponent<Animator>().SetLayerWeight(0, 1);
            GetComponent<Animator>().SetLayerWeight(1, 0);
            GetComponent<Animator>().SetLayerWeight(2, 0);
        }


        if (health == 2)
        {

            GetComponent<Animator>().SetLayerWeight(0, 0);
            GetComponent<Animator>().SetLayerWeight(1, 1);
            GetComponent<Animator>().SetLayerWeight(2, 0);
        }

        if (health == 1)
        {

            GetComponent<Animator>().SetLayerWeight(0, 0);
            GetComponent<Animator>().SetLayerWeight(1, 0);
            GetComponent<Animator>().SetLayerWeight(2, 1);
        }



        if (health <= 0 && !mined)
        {

            StartCoroutine("Mined");
        }


    }

    public void Hit()
    {
        if (health > 1)
        {
            audioSource.PlayOneShot(coinHit1, 0.7F);
        }


        if (health >= 1)
            health = health - 1;

    }

    public IEnumerator Mined (){

        mined = true;
        Instantiate(coinDeath, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        bitCoinScoreManager.AddPoints(pointsToGive);
        bitCoinCounter.AddPoints(1);
        Destroy(this.gameObject);
    }
}
