using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUnlock : MonoBehaviour
{
        [Header("Images")]
        [SerializeField] private GameObject characterTwo;
        [SerializeField] private GameObject characterThree;
        [SerializeField] private GameObject characterFour;
        [SerializeField] private GameObject characterFive;
        [SerializeField] private GameObject characterSix;

        [Header("Buttons")]
        [SerializeField] private GameObject characterButtonTwo;
        [SerializeField] private GameObject characterButtonThree;
        [SerializeField] private GameObject characterButtonFour;
        [SerializeField] private GameObject characterButtonFive;
        [SerializeField] private GameObject characterButtonSix;

        [Header("Icons")]
        [SerializeField] private GameObject characterTwoLock;
        [SerializeField] private GameObject characterThreeLock;
        [SerializeField] private GameObject characterFourLock;
        [SerializeField] private GameObject characterFiveLock;
        [SerializeField] private GameObject characterSixLock;

        [SerializeField] private Sprite checkMark;

        private void Awake()
        {
                PlayerPrefs.SetString("CharacterOne", "True");

                PlayerPrefs.SetString("CharacterChoice", "CharacterOne");
        }

        private void Update()
        {
                if (PlayerPrefs.GetString("CharacterTwo") == "True")
                {
                        characterTwo.GetComponent<Image>().color = Color.white;
                        characterTwoLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonTwo.SetActive(false);
                }
                if (PlayerPrefs.GetString("CharacterThree") == "True")
                {
                        characterThree.GetComponent<Image>().color = Color.white;
                        characterThreeLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonThree.SetActive(false);
                }
                if (PlayerPrefs.GetString("CharacterFour") == "True")
                {
                        characterFour.GetComponent<Image>().color = Color.white;
                        characterFourLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonFour.SetActive(false);
                }
                if (PlayerPrefs.GetString("CharacterFive") == "True")
                {
                        characterFive.GetComponent<Image>().color = Color.white;
                        characterFiveLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonFive.SetActive(false);
                }
                if (PlayerPrefs.GetString("CharacterSix") == "True")
                {
                        characterSix.GetComponent<Image>().color = Color.white;
                        characterSixLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonSix.SetActive(false);
                }
        }

        public void CharacterTwoUnlock()
        {
                if (PlayerPrefs.GetInt("CoinTotal") >= 500)
                {
                        PlayerPrefs.SetInt("CoinTotal", (PlayerPrefs.GetInt("CoinTotal") - 500));
                        characterTwo.GetComponent<Image>().color = Color.white;
                        characterTwoLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonTwo.SetActive(false);
                        PlayerPrefs.SetString("CharacterTwo", "True");
                }
        }

        public void CharacterThreeUnlock()
        {
                if (PlayerPrefs.GetInt("CoinTotal") >= 1500)
                {
                        PlayerPrefs.SetInt("CoinTotal", (PlayerPrefs.GetInt("CoinTotal") - 1500));
                        characterThree.GetComponent<Image>().color = Color.white;
                        characterThreeLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonThree.SetActive(false);
                        PlayerPrefs.SetString("CharacterThree", "True");
                }
        }

        public void CharacterFourUnlock()
        {
                if (PlayerPrefs.GetInt("CoinTotal") >= 4000)
                {
                        PlayerPrefs.SetInt("CoinTotal", (PlayerPrefs.GetInt("CoinTotal") - 4000));
                        characterFour.GetComponent<Image>().color = Color.white;
                        characterFourLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonFour.SetActive(false);
                        PlayerPrefs.SetString("CharacterFour", "True");
                }
        }

        public void CharacterFiveUnlock()
        {
                if (PlayerPrefs.GetInt("CoinTotal") >= 10000)
                {
                        PlayerPrefs.SetInt("CoinTotal", (PlayerPrefs.GetInt("CoinTotal") - 10000));
                        characterFive.GetComponent<Image>().color = Color.white;
                        characterFiveLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonFive.SetActive(false);
                        PlayerPrefs.SetString("CharacterFive", "True");
                }
        }

        public void CharacterSixUnlock()
        {
                if (PlayerPrefs.GetInt("CoinTotal") >= 25000)
                {
                        PlayerPrefs.SetInt("CoinTotal", (PlayerPrefs.GetInt("CoinTotal") - 25000));
                        characterSix.GetComponent<Image>().color = Color.white;
                        characterSixLock.GetComponent<Image>().sprite = checkMark;
                        characterButtonSix.SetActive(false);
                        PlayerPrefs.SetString("CharacterSix", "True");
                }
        }
}
