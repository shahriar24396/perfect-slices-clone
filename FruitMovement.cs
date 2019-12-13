using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float moveSpeed;
    public float speedIncrement;
    bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGameOver = FindObjectOfType<KnifeChopAnim>().isGameOver;

        if (Input.GetKey(KeyCode.Space))
        {
            moveSpeed += speedIncrement;
        }

        if (isGameOver == false)
        {
            rb.velocity = new Vector3(moveSpeed, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
        }
    }
}
