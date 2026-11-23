using UnityEngine;

public class bgSpawner : MonoBehaviour
{
    public GameObject bg;
    private float timer = 0f;
    private float spawnRate = 95f;
    private float bgCoor = 48f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBg();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnBg();
            timer = 0;
        }
    }

    void SpawnBg()
    {
        Instantiate(bg, new Vector3(bgCoor, 0, 0), transform.rotation);
    }
}
