using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTile : MonoBehaviour
{
    public float shakeDuration = 1f; // Duration of the shaking in seconds
    public float shakeMagnitude = 0.1f; // Magnitude of the shaking
    public float fallSpeed = 2f; // Speed of the falling

    private Vector3 originalPosition;
    private Transform playerTransform;

    void Start()
    {
        originalPosition = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTransform = collision.gameObject.transform;
            playerTransform.parent = transform;
            StartCoroutine(ShakeAndFall());
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTransform.parent = null;
        }
    }

    IEnumerator ShakeAndFall()
    {
        float elapsed = 0.0f;

        while (elapsed < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitude;
            float y = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.position = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        playerTransform.parent = null;
        transform.position = originalPosition;

        while (true)
        {
            transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);

            yield return null;
        }
    }
}