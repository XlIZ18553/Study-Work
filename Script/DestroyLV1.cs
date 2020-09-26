using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLV1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Destroytext());
    }

    IEnumerator Destroytext()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
