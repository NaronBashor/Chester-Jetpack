using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
        [SerializeField] private float projectileSpeed;        
        [SerializeField] private int projectileDamage = 34;        

        GameObject target;
        Rigidbody2D rb;

        private void Start()
        {
                rb = GetComponent<Rigidbody2D>();
                target = GameObject.FindGameObjectWithTag("Player");
                Vector2 moveDir = (target.transform.position - transform.position).normalized * projectileSpeed;
                rb.velocity = new Vector2(moveDir.x, moveDir.y);
                if (target.transform.position.x < transform.position.x)
                {
                        transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                        transform.localScale = new Vector3(1, 1, 1);
                        projectileSpeed = 2;
                }
        }

        private void Update()
        {
                if (transform.position.x < -25 || transform.position.x > 25 || transform.position.y > 25 || transform.position.y < -25)
                {
                        Destroy(gameObject);
                }
        }        

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision.CompareTag("Player"))
                {
                        Damageable dam = collision.GetComponent<Damageable>();
                        if (dam != null)
                        {
                                dam.OnHit(projectileDamage);
                                Destroy(gameObject);
                        }
                }
        }
}
