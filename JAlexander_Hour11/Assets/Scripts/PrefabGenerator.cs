using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnRange;
    // Start is called before the first frame update
    void Start()
    {
       
       
        for (int i = 1; i <= 10; i++)
        {
            
            Instantiate<GameObject>(prefab, new Vector3(1f*i, 0.7f, 0f), Quaternion.identity);
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
