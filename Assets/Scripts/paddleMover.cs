using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMover : MonoBehaviour
{
    public float speed = 5.0f;
    public float minX = -2.25f;
    public float maxX = 2.25f;

    float movementHorizontal;

    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");

        if ((movementHorizontal > 0 && transform.position.x < maxX) || (movementHorizontal < 0 && transform.position.x > minX))
        {
            float moveAmount = Time.deltaTime * speed * movementHorizontal;
            float newX = Mathf.Clamp(transform.position.x + moveAmount, minX, maxX);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}
