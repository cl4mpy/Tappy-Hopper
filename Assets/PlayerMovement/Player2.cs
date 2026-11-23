using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpStrength = 5.2f;
    private float maxRotationAngleDown = 30f;
    private float maxRotationAngleUp = 15f;
    private float rotationSpeed;
    private float currentZ = 0f;
    private float targetZ = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.linearVelocity = Vector2.up * jumpStrength;
        }

        float verticalV = rb.linearVelocity.y;

        if (verticalV > 0.1f) {
            targetZ = maxRotationAngleUp;
            rotationSpeed = 14f;
        }
        else {
            targetZ = -maxRotationAngleDown;
            rotationSpeed = 3f;
        }

        currentZ = Mathf.LerpAngle(currentZ, targetZ, rotationSpeed * Time.deltaTime);
        currentZ = Mathf.Clamp(currentZ, -maxRotationAngleDown, maxRotationAngleUp);
        
        transform.rotation = Quaternion.Euler(0, 0, currentZ);
    }
}
