using UnityEngine;
using TMPro;

public class floatingSubTitle : MonoBehaviour
{
    public float maxH = 5f;
    public float speed = 3f;
    private Vector3 startPos;

    public float speedfade = 2.5f;
    private TextMeshProUGUI tmp;
    private Color baseColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition;
        tmp = GetComponent<TextMeshProUGUI>();
        baseColor = tmp.color;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time * speed) * maxH;
        transform.localPosition = startPos + new Vector3(0, y, 0);

        float a = (Mathf.Sin(Time.time * speedfade) + 1f) / 2f; // 0–1
        tmp.color = new Color(baseColor.r, baseColor.g, baseColor.b, a);
    }
}