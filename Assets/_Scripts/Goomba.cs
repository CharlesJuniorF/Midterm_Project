using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public Sprite flatSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (player.starPower)
            {
                Hit();
            }
            else if (collision.transform.DotTest(transform, Vector2.down))
            {
                FlattenGoomba();
            }
            else
            {
                player.Hit();
            }
        }

        else if (collision.gameObject.CompareTag("Arrow"))
        {
            Hit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Shelled"))
        {
            Hit();
        }
    }

    private void FlattenGoomba()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<EntitiyMovement>().enabled = false;
        GetComponent<SpriteAnimator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = flatSprite;

        Destroy(gameObject, 0.5f);
    }

    private void Hit()
    {
        GetComponent<SpriteAnimator>().enabled = false;
        GetComponent<DeathAnimation>().enabled = true;
        Destroy(gameObject, 3.0f);
    }
}
