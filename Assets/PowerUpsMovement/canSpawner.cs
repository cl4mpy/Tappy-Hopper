using UnityEngine;

public class canSpawner : MonoBehaviour
{
    public GameObject can;
    private float timer = 0f;
    private float spawnRate;
    private float YOffset = 7f;
    private float spawnScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(32f, 45f);
        spawnScale = Random.Range(0.9f, 1.3f);

        if (timer <= spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCan();
            timer = 0;
        }
    }

    void SpawnCan()
    {
        float maxY = transform.position.y + YOffset;
        float minY = transform.position.y - YOffset;

        GameObject newPipe = Instantiate(can, new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z), transform.rotation);
        newPipe.transform.localScale = Vector3.one * spawnScale;
    }
}
