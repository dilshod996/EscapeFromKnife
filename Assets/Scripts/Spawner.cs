using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject knife;

    float min_x = -2.78f;
    float max_x = 2.78f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        GameObject k = Instantiate(knife);
        float x = Random.Range(min_x, max_x);
        k.transform.position = new Vector2(x, transform.position.y);
        StartCoroutine(StartSpawning());

    }
}
