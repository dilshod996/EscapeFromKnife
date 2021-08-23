using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        StartCoroutine(CountTime());
    }

    // Update is called once per frame

    IEnumerator CountTime()
    {
        yield return new WaitForSeconds(1);
        time++;
        scoreText.text = "Timer: " + time;
        StartCoroutine(CountTime());
    }
}
