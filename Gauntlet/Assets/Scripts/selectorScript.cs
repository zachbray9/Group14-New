using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectorScript : MonoBehaviour
{
    private GameObject[] characterList;
    private int index; 

    private void Start()
    {
        characterList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in characterList)
            go.SetActive(false);

        if (characterList[0])
            characterList[0].SetActive(true);
        
    }

    

    public void ToggleBerserker()
    {
        characterList[index].SetActive(false);


        characterList[0].SetActive(true);
        index = 0;
    }
    public void ToggleMage()
    {
        characterList[index].SetActive(false);


        characterList[1].SetActive(true);
        index = 1;


    }
    public void ToggleArcher()
    {
        characterList[index].SetActive(false);


        characterList[2].SetActive(true);
        index = 2;


    }
    public void TogglePaladin()
    {
        characterList[index].SetActive(false);


        characterList[3].SetActive(true);
        index = 3;
    }
}
