using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricTrap : MonoBehaviour
{
        [SerializeField] private float electricDamage = 34;

        private void OnTriggerEnter2D(Collider2D collision)
        {
                GameObject player = GameObject.Find("Player");
                if (player.GetComponent<Animator>().GetBool("shieldActive"))
                {
                        if (collision.CompareTag("Shield"))
                        {
                                Damageable dam = player.GetComponent<Damageable>();
                                if (dam != null)
                                {
                                        dam.OnHit(electricDamage);
                                }
                        }
                }
                else
                {
                        if (collision.CompareTag("Player"))
                        {
                                Damageable dam = collision.GetComponent<Damageable>();
                                if (dam != null)
                                {
                                        dam.OnHit(electricDamage);
                                }
                        }
                }
        }
}
