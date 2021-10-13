using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float YBound = 30;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > YBound || transform.position.z < -YBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}