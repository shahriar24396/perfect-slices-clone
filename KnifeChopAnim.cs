using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeChopAnim : MonoBehaviour
{
    // Start is called before the first frame update
    //public Animator anim;
    public GameObject slice;
    public float choppingSpeed;
    public bool isGameOver = false;
    public bool isLevelComplete = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.touchCount > 0 || Input.GetKey(KeyCode.Space)) && isGameOver == false)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<Animator>().Play("KnifeChop");
            gameObject.GetComponent<Animator>().speed = choppingSpeed;
            //choppingSpeed += 0.001f;
        }

        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.GetComponent<Animator>().Play("KnifeIdle");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER!!!");
            isGameOver = true;
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Slice"))
        {
            //Debug.Log("SLICE!");
            collider.GetComponent<BoxCollider>().isTrigger = false;
            Rigidbody rb = collider.gameObject.AddComponent<Rigidbody>();
            //rb.AddForce(new Vector3(500f, 0f, 0f));
            rb.AddForce(new Vector3(500f, 0f, 0f));
            rb.useGravity = true;
            rb.mass = 20f;            
        }

        if (collider.CompareTag("Finish"))
        {
            Debug.Log("LEVEL COMPLETE");
            isLevelComplete = true;
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
