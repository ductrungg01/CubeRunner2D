using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    UIManager _ui;
    Cube _cube;

    // Start is called before the first frame update
    void Start()
    {
        _cube = FindObjectOfType<Cube>();
        _ui = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _ui.SetScore(_cube.score);

        if (Input.GetKeyDown(KeyCode.G))
        {
            _ui.ShowGameOverPanel(true, _cube.score);
        }
    }
}
