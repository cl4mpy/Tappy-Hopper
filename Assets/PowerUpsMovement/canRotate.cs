using UnityEngine;

public class canRotate : MonoBehaviour
{
    public float rotatespeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotatespeed = (Random.Range(0, 2) == 0) ? 20f : -20f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotatespeed * Time.deltaTime);
    }
}
