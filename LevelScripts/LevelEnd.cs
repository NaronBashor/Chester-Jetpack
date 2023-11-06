using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
        [Header("Trophies")]
        [SerializeField] private GameObject bronzeTrophy;
        [SerializeField] private GameObject silverTrophy;
        [SerializeField] private GameObject goldTrophy;

        [SerializeField] private GameObject endOfLevelPanel;

        [SerializeField] private int level;

        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI shieldText;
        [SerializeField] private TextMeshProUGUI bombText;
        [SerializeField] private TextMeshProUGUI magnetText;

        [SerializeField] private AudioSource levelEndSound;

        private void OnTriggerEnter2D(Collider2D collision)
        {
                if (collision != null)
                {
                        if (collision.CompareTag("Player"))
                        {
                                levelEndSound.Play();
                                endOfLevelPanel.SetActive(true);
                                PlayerPrefs.SetString("Level" + (level + 1) + "Unlock", "True");
                                PlayerPrefs.SetInt("CoinTotal", collision.GetComponent<PlayerMovement>().CoinTotal + PlayerPrefs.GetInt("CoinTotal"));
                                scoreText.text = GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter.ToString("#,#");
                                GameObject.Find("Player").GetComponent<Animator>().SetBool("levelEnd", true);
                                shieldText.text = GameObject.Find("Player").GetComponent<PlayerMovement>().ShieldCount.ToString();
                                bombText.text = GameObject.Find("Player").GetComponent<PlayerMovement>().BombCount.ToString();
                                magnetText.text = GameObject.Find("Player").GetComponent<PlayerMovement>().MagnetCount.ToString();
                        }

                        if (level == 1 )
                        {
                                if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 7000)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(true);
                                        PlayerPrefs.SetInt("LevelOneTrophy", 3);
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 7000 && GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 6500)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(true);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelOneTrophy") != 3)
                                        {
                                                PlayerPrefs.SetInt("LevelOneTrophy", 2);
                                        }                                        
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 6500)
                                {
                                        bronzeTrophy.SetActive(true);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelOneTrophy") != 3 && PlayerPrefs.GetInt("LevelOneTrophy") != 2)
                                        {
                                                PlayerPrefs.SetInt("LevelOneTrophy", 1);
                                        }                                        
                                }
                        }

                        if (level == 2)
                        {
                                if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 7000)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(true);
                                        PlayerPrefs.SetInt("LevelTwoTrophy", 3);
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 7000 && GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 6500)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(true);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelTwoTrophy") != 3)
                                        {
                                                PlayerPrefs.SetInt("LevelTwoTrophy", 2);
                                        }                                        
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 6500)
                                {
                                        bronzeTrophy.SetActive(true);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelTwoTrophy") != 3 && PlayerPrefs.GetInt("LevelTwoTrophy") != 2)
                                        {
                                                PlayerPrefs.SetInt("LevelTwoTrophy", 1);
                                        }                                        
                                }
                        }

                        if (level == 3)
                        {
                                if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 7000)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(true);
                                        PlayerPrefs.SetInt("LevelThreeTrophy", 3);
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 7000 && GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 6500)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(true);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelThreeTrophy") != 3)
                                        {
                                                PlayerPrefs.SetInt("LevelThreeTrophy", 2);
                                        }                                        
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 6500)
                                {
                                        bronzeTrophy.SetActive(true);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelThreeTrophy") != 3 && PlayerPrefs.GetInt("LevelThreeTrophy") != 2)
                                        {
                                                PlayerPrefs.SetInt("LevelThreeTrophy", 1);
                                        }                                                
                                }
                        }

                        if (level == 4)
                        {
                                if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 7000)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(true);
                                        PlayerPrefs.SetInt("LevelFourTrophy", 3);
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 7000 && GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter >= 6500)
                                {
                                        bronzeTrophy.SetActive(false);
                                        silverTrophy.SetActive(true);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelFourTrophy") != 3)
                                        {
                                                PlayerPrefs.SetInt("LevelFourTrophy", 2);
                                        }                                        
                                }
                                else if (GameObject.Find("Player").GetComponent<PlayerMovement>().ScoreCounter < 6500)
                                {
                                        bronzeTrophy.SetActive(true);
                                        silverTrophy.SetActive(false);
                                        goldTrophy.SetActive(false);
                                        if (PlayerPrefs.GetInt("LevelFourTrophy") != 3 && PlayerPrefs.GetInt("LevelFourTrophy") != 2)
                                        {
                                                PlayerPrefs.SetInt("LevelFourTrophy", 1);
                                        }                                                
                                }
                        }
                }
        }
}
