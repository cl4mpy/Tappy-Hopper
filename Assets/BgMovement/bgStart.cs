using UnityEngine;

public class bgStart : MonoBehaviour
{
    public float bgmovespeed = 0.5f;
    private float bgDestroy = -48f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left) * bgmovespeed * Time.deltaTime;

        if (transform.position.x < bgDestroy) {
            Destroy(gameObject);
        }
    }
}
