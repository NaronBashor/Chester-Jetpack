using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damageable : MonoBehaviour
{
        Animator anim;
        Rigidbody2D rb;

        [SerializeField] private int health = 100;
        [SerializeField] private int maxHealth = 100;
        [SerializeField] private float shieldHealth = 100;
        [SerializeField] private GameObject shield;
        [SerializeField] private GameObject shieldBar;
        [SerializeField] private GameObject deathPanel;
        [SerializeField] private Image fillImage;

        public int Health
        {
                get
                {
                        return health;
                }
                set
                {
                        health = value;
                }
        }

        public int MaxHealth
        {
                get
                {
                        return maxHealth;
                }
                set
                {
                        maxHealth = value;
                }
        }

        private void Start()
        {
                anim = GetComponent<Animator>();
                rb = GetComponent<Rigidbody2D>();

                deathPanel.SetActive(false);

                health = maxHealth;
                fillImage.fillAmount = shieldHealth;
        }

        private void Update()
        {
                if (health <= 0)
                {
                        anim.SetBool("isAlive", false);
                        anim.SetTrigger("dead");
                        anim.SetBool("canMove", false);
                        rb.gravityScale = 0f;
                        rb.velocity = Vector3.zero;
                        deathPanel.SetActive(true);
                }
                else
                {
                        anim.SetBool("isAlive", true);
                }
                if (anim.GetBool("shieldActive"))
                {
                        shield.SetActive(true);
                        shieldBar.SetActive(true);
                }
                else if (!anim.GetBool("shieldActive"))
                {
                        shield.SetActive(false);
                        shieldBar.SetActive(false);
                }
                if (shieldHealth < 1)
                {
                        StartCoroutine(Delay());
                        IEnumerator Delay()
                        {
                                yield return new WaitForSeconds(.2f);
                                anim.SetBool("shieldActive", false);
                        }                        
                }
        }

        public void OnHit(float damage)
        {
                if (ShieldActive())
                {
                        shieldHealth -= damage;
                        fillImage.fillAmount -= damage / 100;
                }
                else
                {
                        health -= (int)damage;
                }
        }

        public bool ShieldActive()
        {
                if (anim.GetBool("shieldActive") && shieldHealth > 0)
                {
                        return true;
                }
                else
                {
                        return false;
                }
        }
}
