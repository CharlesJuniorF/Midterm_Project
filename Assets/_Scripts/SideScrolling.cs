using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrolling : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 camerPosition = transform.position;
        camerPosition.x = Mathf.Max(camerPosition.x, player.position.x);
        transform.position = camerPosition;
    }
}
