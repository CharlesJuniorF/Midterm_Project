using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer largeRenderer;

    private DeathAnimation deathAnimation;

    public bool big => largeRenderer.enabled;
    public bool small => smallRenderer.enabled;
    public bool dead => deathAnimation.enabled;

    private void Awake()
    {
        deathAnimation = GetComponent<DeathAnimation>();
    }

    public void Hit()
    {
        if (big)
        {
            Shrink();
        }
        else
        {
            Death();
        }
    }

    private void Shrink()
    {

    }

    private void Death()
    {
        smallRenderer.enabled = false;
        largeRenderer.enabled = false;
        deathAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3.0f);
    }
}
