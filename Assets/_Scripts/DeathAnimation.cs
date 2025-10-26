using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    public Sprite deathSprite;
    public SpriteRenderer spriteRenderer;

    private void Reset()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        UpdateSprite();
        DisablePhysics();
        StartCoroutine(Animate());
    }

    private void UpdateSprite()
    {
        spriteRenderer.enabled = true;
        spriteRenderer.sortingOrder = 10;

        if (deathSprite != null )
        {
            spriteRenderer.sprite = deathSprite;
        }
    }

    private void DisablePhysics()
    {
        Collider2D[] colliders = GetComponents<Collider2D>();

        foreach (Collider2D collider in colliders)
        {
            collider.enabled = false;
        }

        GetComponent<Rigidbody2D>().isKinematic = true;

        PlayerMovment playerMovement = GetComponent<PlayerMovment>();
        EntitiyMovement entityMovement = GetComponent<EntitiyMovement>();

        if (playerMovement != null )
        {
            playerMovement.enabled = false;
        }

        if (entityMovement != null )
        {
            entityMovement.enabled = false;
        }
    }

    private IEnumerator Animate()
    {
        float elapsed = 0.0f;
        float duration = 3.0f;

        float jumpVelocity = 10.0f;
        float gravity = -36.0f;

        Vector3 velocity = Vector3.up * jumpVelocity;

        while (elapsed < duration)
        {
            transform.position += velocity * Time.deltaTime;
            velocity.y += gravity * Time.deltaTime;
            elapsed += Time.deltaTime;

            yield return null;
        }
    }
}
