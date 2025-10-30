using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GraphicUI : MonoBehaviour
{
    public TextMeshProUGUI lives;
    public TextMeshProUGUI coins;
    public TextMeshProUGUI world;
    public TextMeshProUGUI time;

    private GameManager management;

    void Start()
    {
        management = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "MARIO \nx " + management.lives;
        coins.text = $"COINS \nx{management.coins:D2}";
        world.text = "WORLD\n" + management.world + " - " + management.stage;
        time.text = $"TIME\n{management.time:F0}";
    }
}
