using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
        #region Inspector

        [Header("Colors")]
        [SerializeField] private GameObject Level2Color;
        [SerializeField] private GameObject Level3Color;
        [SerializeField] private GameObject Level4Color;
        [SerializeField] private GameObject Level5Color;
        [SerializeField] private GameObject Level6Color;
        [SerializeField] private GameObject Level7Color;
        [SerializeField] private GameObject Level8Color;

        [Header("Trophies")]
        [SerializeField] private GameObject Level1Gold;
        [SerializeField] private GameObject Level1Silver;
        [SerializeField] private GameObject Level1Bronze;
        [SerializeField] private GameObject Level2Gold;
        [SerializeField] private GameObject Level2Silver;
        [SerializeField] private GameObject Level2Bronze;
        [SerializeField] private GameObject Level3Gold;
        [SerializeField] private GameObject Level3Silver;
        [SerializeField] private GameObject Level3Bronze;
        [SerializeField] private GameObject Level4Gold;
        [SerializeField] private GameObject Level4Silver;
        [SerializeField] private GameObject Level4Bronze;
        [SerializeField] private GameObject Level5Gold;
        [SerializeField] private GameObject Level5Silver;
        [SerializeField] private GameObject Level5Bronze;
        [SerializeField] private GameObject Level6Gold;
        [SerializeField] private GameObject Level6Silver;
        [SerializeField] private GameObject Level6Bronze;
        [SerializeField] private GameObject Level7Gold;
        [SerializeField] private GameObject Level7Silver;
        [SerializeField] private GameObject Level7Bronze;
        [SerializeField] private GameObject Level8Gold;
        [SerializeField] private GameObject Level8Silver;
        [SerializeField] private GameObject Level8Bronze;

        [Header("Padlocks")]
        [SerializeField] private GameObject Level2Padlock;
        [SerializeField] private GameObject Level3Padlock;
        [SerializeField] private GameObject Level4Padlock;
        [SerializeField] private GameObject Level5Padlock;
        [SerializeField] private GameObject Level6Padlock;
        [SerializeField] private GameObject Level7Padlock;
        [SerializeField] private GameObject Level8Padlock;

        #endregion        

        private void Start()
        {
                PlayerPrefs.SetString("Level1Unlock", "True");
        }

        public void Update()
        {
                #region Level Unlock

                if (PlayerPrefs.GetString("Level2Unlock") == "True")
                {
                        Level2Color.GetComponent<Image>().color = Color.white;
                        Level2Padlock.SetActive(false);
                }
                if (PlayerPrefs.GetString("Level3Unlock") == "True")
                {
                        Level3Color.GetComponent<Image>().color = Color.white;
                        Level3Padlock.SetActive(false);
                }
                if (PlayerPrefs.GetString("Level4Unlock") == "True")
                {
                        Level4Color.GetComponent<Image>().color = Color.white;
                        Level4Padlock.SetActive(false);
                }
                // New levels are not made yet

                //if (PlayerPrefs.GetString("Level5Unlock") == "True")
                //{
                //        Level5Color.GetComponent<Image>().color = Color.white;
                //        Level5Padlock.SetActive(false);
                //}
                //if (PlayerPrefs.GetString("Level6Unlock") == "True")
                //{
                //        Level6Color.GetComponent<Image>().color = Color.white;
                //        Level6Padlock.SetActive(false);
                //}
                //if (PlayerPrefs.GetString("Level7Unlock") == "True")
                //{
                //        Level7Color.GetComponent<Image>().color = Color.white;
                //        Level7Padlock.SetActive(false);
                //}
                //if (PlayerPrefs.GetString("Level8Unlock") == "True")
                //{
                //        Level8Color.GetComponent<Image>().color = Color.white;
                //        Level8Padlock.SetActive(false);
                //}

                #endregion

                #region Level 1 Trophies

                if (PlayerPrefs.GetInt("LevelOneTrophy") == 1)
                {
                        Level1Bronze.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelOneTrophy") == 2)
                {
                        Level1Silver.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelOneTrophy") == 3)
                {
                        Level1Gold.GetComponent<Image>().color = Color.white;
                }

                #endregion

                #region Level 2 Trophies

                if (PlayerPrefs.GetInt("LevelTwoTrophy") == 1)
                {
                        Level2Bronze.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelTwoTrophy") == 2)
                {
                        Level2Silver.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelTwoTrophy") == 3)
                {
                        Level2Gold.GetComponent<Image>().color = Color.white;
                }

                #endregion

                #region Level 3 Trophies

                if (PlayerPrefs.GetInt("LevelThreeTrophy") == 1)
                {
                        Level3Bronze.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelThreeTrophy") == 2)
                {
                        Level3Silver.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelThreeTrophy") == 3)
                {
                        Level3Gold.GetComponent<Image>().color = Color.white;
                }

                #endregion

                #region Level 4 Trophies

                if (PlayerPrefs.GetInt("LevelFourTrophy") == 1)
                {
                        Level4Bronze.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelFourTrophy") == 2)
                {
                        Level4Silver.GetComponent<Image>().color = Color.white;
                }
                else if (PlayerPrefs.GetInt("LevelFourTrophy") == 3)
                {
                        Level4Gold.GetComponent<Image>().color = Color.white;
                }

                #endregion

                // New level trophies not needed yet

                //#region Level 5 Trophies

                //if (PlayerPrefs.GetInt("LevelFiveTrophy") == 1)
                //{
                //        Level5Bronze.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelFiveTrophy") == 2)
                //{
                //        Level5Silver.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelFiveTrophy") == 3)
                //{
                //        Level5Gold.GetComponent<Image>().color = Color.white;
                //}

                //#endregion

                //#region Level 6 Trophies

                //if (PlayerPrefs.GetInt("LevelSixTrophy") == 1)
                //{
                //        Level6Bronze.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelSixTrophy") == 2)
                //{
                //        Level6Silver.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelSixTrophy") == 3)
                //{
                //        Level6Gold.GetComponent<Image>().color = Color.white;
                //}

                //#endregion

                //#region Level 7 Trophies

                //if (PlayerPrefs.GetInt("LevelSevenTrophy") == 1)
                //{
                //        Level7Bronze.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelSevenTrophy") == 2)
                //{
                //        Level7Silver.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelSevenTrophy") == 3)
                //{
                //        Level7Gold.GetComponent<Image>().color = Color.white;
                //}

                //#endregion

                //#region Level 8 Trophies

                //if (PlayerPrefs.GetInt("LevelEightTrophy") == 1)
                //{
                //        Level8Bronze.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelEightTrophy") == 2)
                //{
                //        Level8Silver.GetComponent<Image>().color = Color.white;
                //}
                //else if (PlayerPrefs.GetInt("LevelEightTrophy") == 3)
                //{
                //        Level8Gold.GetComponent<Image>().color = Color.white;
                //}

                //#endregion
        }
}
