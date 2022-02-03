using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float mSpeed = 30f;
    [SerializeField] float slowSpeed = 20f;
    [SerializeField] float boostSpeed = 50f;



    // Update is called once per frame
    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float Movement = Input.GetAxis("Vertical") * mSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, Movement, 0);
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        mSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            mSpeed = boostSpeed;
        }

    }
}
