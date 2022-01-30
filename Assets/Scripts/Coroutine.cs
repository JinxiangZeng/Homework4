using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    void OnMouseDown()
    {
        StartCoroutine(CoroutineFunction());
    }

    IEnumerator CoroutineFunction()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color c = renderer.material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.5f)
        {
            c.a = alpha;
            renderer.material.color = c;
            yield return null;
        }
        Destroy(gameObject);
    }
}
