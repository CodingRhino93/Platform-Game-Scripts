using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float speed = 7f;
    public int damage = 5;

    private Rigidbody2D rb;
    private Player target;
    private Vector2 moveDirection;
    
    public GameObject impactEffect;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if(player != null)
        {
            player.TakeDamage(damage);    
        }

        GameObject bulletImpactEffectAnim = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(bulletImpactEffectAnim, 0.35f);
        Destroy(gameObject);
    }
}
