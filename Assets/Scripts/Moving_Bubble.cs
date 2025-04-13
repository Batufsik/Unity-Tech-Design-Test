using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Bubble : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y > 7)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(0, -14, 0) * Random.Range(1f, 1.6f), 1f);
        }
        transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up, 0.1f);
    }
}
