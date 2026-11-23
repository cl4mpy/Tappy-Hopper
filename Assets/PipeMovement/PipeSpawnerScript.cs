using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float timer = 0f;
    private float spawnRate = 4f;
    private float YOffset = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float maxY = transform.position.y + YOffset;
        float minY = transform.position.y - YOffset;

        GameObject newPipe = Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z), transform.rotation);
    }
}
