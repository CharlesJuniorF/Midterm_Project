using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerMovment movement;

    public Sprite idle;
    public Sprite jump;
    public Sprite run;
    public Sprite slide;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<PlayerMovment>();
    }

    private void LateUpdate()
    {
        if (movement.jumping)
        {
            spriteRenderer.sprite = jump;
        }
        else if (movement.sliding)
        {
            spriteRenderer.sprite = slide;
        }
        else if (movement.running)
        {
            spriteRenderer.sprite = run;
        }
        else
        {
            spriteRenderer.sprite = idle;
        }
    }
}
