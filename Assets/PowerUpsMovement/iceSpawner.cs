using UnityEngine;

public class iceSpawner : MonoBehaviour
{
    public GameObject ice;
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
        spawnRate = Random.Range(68f, 82f);
        spawnScale = Random.Range(1f, 1.2f);

        if (timer <= spawnRate) {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnIce();
            timer = 0;
        }
    }

    void SpawnIce()
    {
        float maxY = transform.position.y + YOffset;
        float minY = transform.position.y - YOffset;

        GameObject newPipe = Instantiate(ice, new Vector3(30, Random.Range(minY, maxY), transform.position.z), transform.rotation);
        newPipe.transform.localScale = Vector3.one * spawnScale;
    }
}
