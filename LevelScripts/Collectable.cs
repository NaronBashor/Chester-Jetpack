using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
        [SerializeField] private string itemName;
        [SerializeField] private int coinScoreAmount = 100;        

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision != null)
                {
                        if (collision.CompareTag("Player"))
                        {
                                if (itemName != null)
                                {
                                        if (itemName == "Bomb")
                                        {
                                                GameObject.Find("Player").GetComponent<PlayerMovement>().BombCount++;
                                                Destroy(gameObject);
                                        }
                                        if (itemName == "Magnet")
                                        {
                                                GameObject.Find("Player").GetComponent<PlayerMovement>().MagnetCount++;
                                                Destroy(gameObject);
                                        }
                                        if(itemName == "Shield")
                                        {
                                                GameObject.Find("Player").GetComponent<PlayerMovement>().ShieldCount++;
                                                Destroy(gameObject);
                                        }
                                        if (itemName == "Coin")
                                        {
                                                GameObject.Find("Player").GetComponent<PlayerMovement>().CoinTotal++;
                                                GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter += coinScoreAmount;
                                                Destroy(gameObject);
                                        }
                                }
                        }
                }
        }
}
