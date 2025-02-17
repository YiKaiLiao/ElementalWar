﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenu : MonoBehaviour
{
    
    public GameObject[] playerObjects;
    public static int selectedCharacter = 0;
    void Start(){
        HideAllCharacters();
        selectedCharacter = PlayerPrefs.GetInt(StartButton.selectedCharacterName, 0);
        playerObjects[selectedCharacter].SetActive(true);
        StartButton.selectedCharacterName = playerObjects[selectedCharacter].name;
    }


    private void HideAllCharacters(){
        foreach (GameObject g in playerObjects){
            g.SetActive(false);
        }
    }

    public void NextCharacter(){
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if (selectedCharacter >= playerObjects.Length){
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
        StartButton.selectedCharacterName = playerObjects[selectedCharacter].name;
    }

    public void PreviousCharacter(){
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0){
            selectedCharacter = playerObjects.Length-1;
        }
        playerObjects[selectedCharacter].SetActive(true);
        StartButton.selectedCharacterName = playerObjects[selectedCharacter].name;
    }
}
