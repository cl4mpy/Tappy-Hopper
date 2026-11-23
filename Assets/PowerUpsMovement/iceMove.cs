using UnityEngine;

public class iceMove : MonoBehaviour
{
    public float movementSpeed = 2.1f;
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
