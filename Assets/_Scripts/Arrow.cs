using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 12.0f;
    public int hitsLeft = 2;

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hitsLeft == 0 || collision.gameObject.CompareTag("Untagged"))
        {
            Destroy(gameObject);
        }
        else
        {
            hitsLeft--;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
