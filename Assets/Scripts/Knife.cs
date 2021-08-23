using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] int damage = 1;

    public int GetDamage()
    {
        return damage;
    }
    public void Hit()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update

}
