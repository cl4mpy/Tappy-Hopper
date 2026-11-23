using UnityEngine;
using System.Collections;

public class canFX : MonoBehaviour
{
    public GameObject bubble;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null) {
            

            Destroy(gameObject);
            Destroy(bubble);
        }
    }
}
