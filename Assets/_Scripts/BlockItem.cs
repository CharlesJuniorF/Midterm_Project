using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockItem : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Animate());
    }

    private IEnumerator Animate()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        CapsuleCollider2D mainCollider = GetComponent<CapsuleCollider2D>();
        BoxCollider2D triggerCollider = GetComponent<BoxCollider2D>();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        rigidBody.isKinematic = true;
        mainCollider.enabled = false;
        triggerCollider.enabled = false;   
        spriteRenderer.enabled = false;

        yield return new WaitForSeconds(0.25f);

        spriteRenderer.enabled = true;

        float elapsed = 0f;
        float duration = 0.5f;

        Vector3 start = transform.localPosition;
        Vector3 end = transform.localPosition + Vector3.up;

        while (elapsed < duration)
        {
            float t = elapsed / duration;

            transform.position = Vector3.Lerp(start, end, t);
            elapsed += Time.deltaTime;

            yield return null;
        }

        rigidBody.isKinematic = false;
        mainCollider.enabled = true;
        triggerCollider.enabled = true;
    }

    
}
