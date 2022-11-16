using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obstacle;
    float spawnTime;
    float spawnDownTime = 2.7f;

    UIManager _ui;
    Cube _cube;

    // Start is called before the first frame update
    void Start()
    {
        _cube = FindObjectOfType<Cube>();
        _ui = FindObjectOfType<UIManager>();

        spawnTime = spawnDownTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            spawnTime = spawnDownTime;

            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        Vector2 pos = new Vector2(14, Random.Range(-3.5f, -2.0f));

        if (obstacle != null)
        {
            Instantiate(obstacle, pos, Quaternion.identity);
        }
    }
}
