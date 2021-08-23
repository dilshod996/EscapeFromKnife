using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Animator anim;
    SpriteRenderer sr;
    float min_x = -2.49f;
    float max_x = 2.49f;
    [SerializeField] int health = 5;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        SetBoundries();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Knife knife = other.gameObject.GetComponent<Knife>();
        if (!knife) { return; }
        ProccessHit(knife);
    }
    private void ProccessHit(Knife knife)
    {
        knife.Hit();
        health -= knife.GetDamage();
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    public int GetHealth()
    {
        return health;
    }
    private void SetBoundries()
    {
        Vector2 bound = transform.position;
        if (bound.x > max_x)
        {
            bound.x = max_x;
        }
        else if (bound.x < min_x)
        {
            bound.x = min_x;
        }
        transform.position = bound;
    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 col = transform.position;
        if (h > 0)
        {
            col.x += speed * Time.deltaTime;
            sr.flipX = false;
            anim.SetBool("Walk", true);
        }
        else if(h < 0)
        {
            col.x -= speed * Time.deltaTime;
            sr.flipX = true;
            anim.SetBool("Walk", true);
        }
        else if( h == 0)
        {
            anim.SetBool("Walk", false);
        }
        transform.position = col;
    }
}
