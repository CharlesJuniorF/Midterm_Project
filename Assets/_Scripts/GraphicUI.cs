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
        lives.text = "MARIO \nx " + management.lives.ToString();
        coins.text = $"COINS \nx{management.coins:D2}";
        world.text = "WORLD\n" + management.world.ToString() + " - " + management.stage.ToString();
        time.text = $"TIME\n{management.time:D3}";
    }
}
