using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCoin : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.AddCoin();

        StartCoroutine(Animate());
    }

    private IEnumerator Animate()
    {
        Vector3 resting = transform.localPosition;
        Vector3 animated = resting + Vector3.up * 2.0f;

        yield return Move(resting, animated);
        yield return Move(animated, resting);

        Destroy(gameObject);

    }

    private IEnumerator Move(Vector3 from, Vector3 to)
    {
        float elapsed = 0f;
        float duration = 0.25f;

        while (elapsed < duration)
        {
            float t = elapsed / duration;

            transform.localPosition = Vector3.Lerp(from, to, t);
            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = to;
    }
}
