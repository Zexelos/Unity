using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    Vector3 movementDirection;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = movementDirection.normalized;

        transform.Translate(velocity * movementSpeed * Time.deltaTime);
    }
}
