using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject startPos;
    public GameObject marioPrefab;
    public int lives = 5;

    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
