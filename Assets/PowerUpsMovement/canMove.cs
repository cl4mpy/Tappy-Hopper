using UnityEngine;

public class canMove : MonoBehaviour
{
    public float movementSpeed = 1.8f;
    private float destroyCoor = -30f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movementSpeed) * Time.deltaTime;

        if (transform.position.x < destroyCoor) {
            Destroy(gameObject);
        }
    }
}
