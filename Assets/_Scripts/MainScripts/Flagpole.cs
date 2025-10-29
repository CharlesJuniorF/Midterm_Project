using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flagpole : MonoBehaviour
{
    public Transform flag;
    public Transform polebottom;
    public Transform castle;
    public float speed = 6.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(MoveTo(flag, polebottom.position));
            StartCoroutine(LevelCompleteSequence(collision.transform));
        }
    }

    private IEnumerator LevelCompleteSequence(Transform player)
    {
        player.GetComponent<PlayerMovment>().enabled = false;

        yield return MoveTo(player, polebottom.position);
        yield return MoveTo(player, player.position + Vector3.right);
        yield return MoveTo(player, player.position + Vector3.right + Vector3.down);
        yield return MoveTo(player, castle.position);

        player.gameObject.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        LoadNextScene();
    }

    private IEnumerator MoveTo(Transform subject, Vector3 position)
    {
        while (Vector3.Distance(subject.position, position) > 0.125f)
        {
            subject.position = Vector3.MoveTowards(subject.position, position, speed * Time.deltaTime);
            yield return null;
        }

        subject.position = position;
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
