using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCeator : MonoBehaviour
{
    public GameObject platformPrefab;

    float randomHeight = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlatform()
    {
        Instantiate(platformPrefab, new Vector3(12, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }
}
