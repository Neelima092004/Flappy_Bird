using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject clouds;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }

    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.x - heightOffset;
        Instantiate(clouds, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
