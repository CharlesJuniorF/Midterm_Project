using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer largeRenderer;
    public PlayerSpriteRenderer arrowRenderer;

    private PlayerSpriteRenderer activeRenderer;
    private CapsuleCollider2D capsuleCollider;

    private DeathAnimation deathAnimation;

    public bool big => largeRenderer.enabled;
    public bool small => smallRenderer.enabled;
    public bool dead => deathAnimation.enabled;
    public bool arrowPower => arrowRenderer.enabled;
    public bool starPower { get; private set; }

    private void Awake()
    {
        deathAnimation = GetComponent<DeathAnimation>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        activeRenderer = smallRenderer;
    }

    public void Hit()
    {
        if (!dead && !starPower)
        {
            if (arrowPower)
            {
                Grow();
            }
            else if (big)
            {
                Shrink();
            }
            else
            {
                Death();
            }
        }
    }

    private void Death()
    {
        smallRenderer.enabled = false;
        largeRenderer.enabled = false;
        deathAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3.0f);
    }

    public void Grow()
    {
        smallRenderer.enabled = false;
        largeRenderer.enabled = true;
        activeRenderer = largeRenderer;

        capsuleCollider.size = new Vector2(1.0f, 2.0f);
        capsuleCollider.offset = new Vector2(0.0f, 0.5f);

        StartCoroutine(ScaleAnimator());
    }

    private void Shrink()
    {
        smallRenderer.enabled = true;
        largeRenderer.enabled = false;
        activeRenderer = smallRenderer;

        capsuleCollider.size = new Vector2(1.0f, 1.0f);
        capsuleCollider.offset = new Vector2(0.0f, 0.0f);

        StartCoroutine(ScaleAnimator());
    }

    public void ArrowPower()
    {
        if (smallRenderer.enabled)
        {
            smallRenderer.enabled = false;
            arrowRenderer.enabled = true;
        }
        else
        {
            largeRenderer.enabled = false;
            arrowRenderer.enabled = true;
        }

        activeRenderer = arrowRenderer;

        capsuleCollider.size = new Vector2(1.0f, 2.0f);
        capsuleCollider.offset = new Vector2(0.0f, 0.5f);

        StartCoroutine (ScaleAnimator());
    }

    private IEnumerator ScaleAnimator()
    {
        float elapsed = 0.0f;
        float duation = 0.5f;

        while (elapsed < duation)
        {
            elapsed += Time.deltaTime;

            if (Time.frameCount % 4 == 0)
            {
                smallRenderer.enabled = !smallRenderer.enabled;
                largeRenderer.enabled = !smallRenderer.enabled;
                arrowRenderer.enabled = !smallRenderer.enabled;
            }

            yield return null;
        }

        smallRenderer.enabled = false;
        largeRenderer.enabled = false;
        arrowRenderer.enabled = false;

        activeRenderer.enabled = true;
    }

    public void StarPower(float duration = 10.0f)
    {
        StartCoroutine(StarPowerAnimator(duration));
    }

    private IEnumerator StarPowerAnimator(float duration)
    {
        starPower = true;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;

            if (Time.frameCount % 4 == 0)
            {
                activeRenderer.spriteRenderer.color = Random.ColorHSV();
            }

            yield return null;
        }

        activeRenderer.spriteRenderer.color = Color.white;

        starPower = false;
    }

    
}
