using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Text health;
    [SerializeField] Player player;


 
    // Start is called before the first frame update
    void Start()
    {

        health = GetComponent<Text>();
        player = FindObjectOfType<Player>();


    }

    // Update is called once per frame
    void Update()
    {
        if (player)
            health.text ="Liver: " +  player.GetHealth().ToString();
    }

}
