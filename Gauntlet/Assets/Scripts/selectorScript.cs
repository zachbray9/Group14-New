using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectorScript : MonoBehaviour
{
    private GameObject[] characterList;
    private static int index; 
    public GameObject PaladinPrefab;
    public GameObject MagePrefab;
    public GameObject ArcherPrefab;
    public GameObject BerserkerPrefab;


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if(sceneName == "CharacterSelect")
        {
            characterList = new GameObject[transform.childCount];

                for(int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;

                foreach (GameObject go in characterList)
            go.SetActive(false);

                if (characterList[0])
            characterList[0].SetActive(true);
        }

        if (sceneName == "SampleScene")
        {
            if (index == 0)
            {
                BerserkerPrefab = Instantiate(BerserkerPrefab, transform.position, transform.rotation);
            }
            if (index == 1)
            {
                MagePrefab = Instantiate(MagePrefab, transform.position, transform.rotation);
            }
            if (index == 2)
            {
                ArcherPrefab = Instantiate(ArcherPrefab, transform.position, transform.rotation);
            }
            if (index == 3)
            {
                PaladinPrefab = Instantiate(PaladinPrefab, transform.position, transform.rotation);
            }
        }
        if (sceneName == "Level2")
        {
            if (index == 0)
            {
                BerserkerPrefab = Instantiate(BerserkerPrefab, transform.position, transform.rotation);
            }
            if (index == 1)
            {
                MagePrefab = Instantiate(MagePrefab, transform.position, transform.rotation);
            }
            if (index == 2)
            {
                ArcherPrefab = Instantiate(ArcherPrefab ,transform.position, transform.rotation);
            }
            if (index == 3)
            {
                PaladinPrefab = Instantiate(PaladinPrefab, transform.position, transform.rotation);
            }
        }
        
        
    }

    

    public void ToggleBerserker()
    {
        characterList[index].SetActive(false);


        characterList[0].SetActive(true);
        index = 0;
        SceneManager.LoadScene("SampleScene");
    }
    public void ToggleMage()
    {
        characterList[index].SetActive(false);


        characterList[1].SetActive(true);
        index = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void ToggleArcher()
    {
        characterList[index].SetActive(false);


        characterList[2].SetActive(true);
        index = 2;
        SceneManager.LoadScene("SampleScene");
    }
    public void TogglePaladin()
    {
        characterList[index].SetActive(false);


        characterList[3].SetActive(true);
        index = 3;
        SceneManager.LoadScene("SampleScene");
    }
}
