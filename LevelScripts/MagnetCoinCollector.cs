using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCoinCollector : MonoBehaviour
{
        [SerializeField] private float coinSpeed;

        private bool moveTowardsPlayer;

        private void Update()
        {
                if (moveTowardsPlayer)
                {
                        GameObject player = GameObject.Find("Player");
                        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, coinSpeed * Time.deltaTime);
                }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision != null)
                {
                        if (collision.CompareTag("MagnetRadius"))
                        {
                                moveTowardsPlayer = true;
                        }
                        else
                        {
                                moveTowardsPlayer = false;
                        }
                }
        }
}
