using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyDeathText : MonoBehaviour
{
        Animator anim;

        [SerializeField] private float textSpeed = 5;
        [SerializeField] private int coinRewardAmount = 500;
        [SerializeField] GameObject textToMove;

        private bool added = false;

        private void Start()
        {
                anim = GetComponent<Animator>();
                textToMove.SetActive(false);
        }

        private void Update()
        {
                if (!anim.GetBool("isAlive"))
                {
                        textToMove.SetActive(true);
                        textToMove.transform.Translate(Vector2.up * textSpeed * Time.deltaTime);
                        if (!added)
                        {
                                AddMoney();
                                added = true;
                        }                        
                }
        }

        public void AddMoney()
        {                
                GameObject player = GameObject.Find("Player");
                player.GetComponent<PlayerMovement>().ScoreCounter += coinRewardAmount;
        }
}
