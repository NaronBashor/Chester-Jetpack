using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{
        [Header("Sprites")]
        [SerializeField] private string characterChosen;
        [SerializeField] private int characterInt;

        public void ChangeCharacter()
        {
                if (PlayerPrefs.GetString(characterChosen) == "True")
                {
                        PlayerPrefs.SetString("CharacterChoice", characterChosen);
                        PlayerPrefs.SetInt("CharacterInt", characterInt);
                }                
        }
}
