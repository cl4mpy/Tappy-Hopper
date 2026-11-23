using UnityEngine;

public class floatingTitle : MonoBehaviour
{
    public float maxH = 25f;
    public float speed = 4f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time * speed) * maxH;
        transform.localPosition = startPos + new Vector3(0, y, 0);
    }
}
