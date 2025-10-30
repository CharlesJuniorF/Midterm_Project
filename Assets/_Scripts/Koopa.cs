using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koopa : MonoBehaviour
{
    public Sprite shellSprite;
    public float shellSpeed = 12.0f;

    private bool shelled;
    private bool pushed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!shelled && collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (player.starPower)
            {
                Hit();
            }
            else if (collision.transform.DotTest(transform, Vector2.down))
            {
                EnterShell();
            }
            else
            {
                player.Hit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (shelled && other.CompareTag("Player"))
        {
            if (!pushed)
            {
                Vector2 direction = new Vector2(transform.position.x - other.transform.position.x, 0.0f);
                PushShell(direction);
            }
            else
            {
                Player player = other.GetComponent<Player>();

                if (player.starPower)
                {
                    Hit();
                }
                else
                {
                    player.Hit();
                }
            }
        }
        else if (!shelled && other.gameObject.layer == LayerMask.NameToLayer("Shell") || other.gameObject.CompareTag("Arrow"))
        {
            Hit();
        }
    }

    private void EnterShell()
    {
        shelled = true;

        GetComponent<EntitiyMovement>().enabled = false;
        GetComponent<SpriteAnimator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = shellSprite;
    }

    private void PushShell(Vector2 direction)
    {
        pushed = true;

        GetComponent<Rigidbody2D>().isKinematic = false;

        EntitiyMovement movement = GetComponent<EntitiyMovement>();
        movement.direction = direction.normalized;
        movement.speed = shellSpeed;
        movement.enabled = true;

        gameObject.layer = LayerMask.NameToLayer("Shelled");
    }
    private void Hit()
    {
        GetComponent<SpriteAnimator>().enabled = false;
        GetComponent<DeathAnimation>().enabled = true;
        Destroy(gameObject, 3.0f);
    }
    private void OnBecameInvisible()
    {
        if (pushed)
        {
            Destroy(gameObject);
        }
    }
}
