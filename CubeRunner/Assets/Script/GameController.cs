using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obstacle;
    float spawnTime;
    float spawnDownTime = 2.7f;

    int score;
    bool isGameover;

    UIManager _ui;
    Cube _cube;

    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
        score = 0;
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

    public void IncScore()
    {
        score++;
        _ui.SetScore(score);
    }

    void SpawnObstacle()
    {
        Vector2 pos = new Vector2(14, Random.Range(-3.5f, -2.0f));

        if (obstacle != null)
        {
            Instantiate(obstacle, pos, Quaternion.identity);
        }
    }

    public void SetGameoverState(bool isGameover)
    {
        this.isGameover = isGameover;

        _ui.ShowGameOverPanel(isGameover, score);
    }
}
