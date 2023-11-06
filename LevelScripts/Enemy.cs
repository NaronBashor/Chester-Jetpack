using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
        Animator anim;

        [SerializeField] GameObject projectilePrefab;
        [SerializeField] Transform projectileLocation;
        [SerializeField] private float attackRange;
        [SerializeField] private float lessAttackRange;
        [SerializeField] private float fireRate = 1f;
        [SerializeField] private float nextFireTime;

        private bool isAlive;

        private void Start()
        {
                anim = GetComponent<Animator>();
                isAlive = true;
        }

        private void Update()
        {
                isAlive = anim.GetBool("isAlive");

                GameObject player = GameObject.Find("Player");
                if (Vector2.Distance(transform.position, player.transform.position) < attackRange && Vector2.Distance(transform.position, player.transform.position) > lessAttackRange && nextFireTime < Time.time && isAlive)
                {
                        OnShoot();
                        nextFireTime = Time.time + fireRate;
                }
                if (player.transform.position.x < transform.position.x && isAlive)
                {
                        transform.localScale = new Vector3(-1, 1, 1);
                }
                else
                {
                        transform.localScale = new Vector3(1, 1, 1);
                }
        }

        public void OnShoot()
        {
                anim.SetTrigger("attack");
                StartCoroutine(Delay());
                IEnumerator Delay()
                {
                        yield return new WaitForSeconds(0.4f);
                        Instantiate(projectilePrefab, projectileLocation.position, Quaternion.identity);
                }
        }

        private void OnDrawGizmos()
        {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(transform.position, attackRange);

                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(transform.position, lessAttackRange);
        }
}
