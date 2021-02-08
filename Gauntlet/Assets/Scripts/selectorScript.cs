using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectorScript : MonoBehaviour
{
    private GameObject[] characterList;
    private static int index; 
    private static int levelNum = 0;
    private static int Lives = 3;
    public bool updateLives = false;
    public bool EndScemeL = false;
    public Text LoseWinText;
    public Text ScoreText;
    public Text LivesText;
    public Text LevelText;
    public GameObject PaladinPrefab;
    public GameObject MagePrefab;
    public GameObject ArcherPrefab;
    public GameObject BerserkerPrefab;
    public static bool GameWin = false;
    public bool GameLose = false;
    


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        
        if(sceneName == "CharacterSelect")
        {
            StatManager.health = 2001;
        }
        if(sceneName == "Losewin")
        {
            EndScemeL = true;
        }
        
       

        if(sceneName == "CharacterSelect")
        {
            LevelText.text = "Character Selection";
            LivesText.text = "Lives\n" + Lives.ToString();

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
            levelNum = 1;
            LevelText.text = "Level 1";
            LivesText.text = "Lives\n" + Lives.ToString();
            
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
            levelNum = 2;

            LevelText.text = "Level 2";
            LivesText.text = "Lives\n" + Lives.ToString();

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

    void Update()
    {
        

        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (sceneName == "LoseWin")
        {

            if(GameLose == true)
            {
                LoseWinText.text = "You Lose, press the R key to restart the game";
                ScoreText.text = "Your Score: " + StatManager.points.ToString();
                if(Input.GetKeyDown("r"))
                {
                    GameLose = false;
                    GameWin = false;
                    StatManager.health = 2001;
                    StatManager.points = 0;
                    Lives = 3;
                    levelNum = 0;
                    EndScemeL = false;
                    SceneManager.LoadScene("CharacterSelect");
                }
            }

            if(GameWin == true)
            {
                LoseWinText.text = "You Win, press the R key to restart the game";
                ScoreText.text = "Your Score: " + StatManager.points.ToString();

                if(Input.GetKeyDown("r"))
                {
                    GameLose = false;
                    GameWin = false;
                    StatManager.health = 2001;
                    StatManager.points = 0;
                    Lives = 3;
                    levelNum = 0;
                    EndScemeL = false;
                    SceneManager.LoadScene("CharacterSelect");
                }
            }
            

            

        }

        if(StatManager.health <= 0 && Lives != 0)
        {
            SceneManager.LoadScene("CharacterSelect");
            updateLives = true;
            StatManager.points = 0;

        }

        if(StatManager.health <= 0 && Lives == 0 && EndScemeL == false)
        {
            
            EndScemeL = true;
            SceneManager.LoadScene("LoseWin");
            
            
            
            
        }
        if(EndScemeL == true)
        {
            GameLose = true;            
        }
        
        if(sceneName == "CharacterSelect")
        {
            StatManager.health = 2001;
        }

        if(updateLives == true)
        {
           Lives = Lives - 1;
           updateLives = false; 
        }
    }

    

    public void ToggleBerserker()
    {
        characterList[index].SetActive(false);


        characterList[0].SetActive(true);
        index = 0;
        if (levelNum == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void ToggleMage()
    {
        characterList[index].SetActive(false);


        characterList[1].SetActive(true);
        index = 1;
        if (levelNum == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void ToggleArcher()
    {
        characterList[index].SetActive(false);


        characterList[2].SetActive(true);
        index = 2;
        if (levelNum == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void TogglePaladin()
    {
        characterList[index].SetActive(false);


        characterList[3].SetActive(true);
        index = 3;
        if (levelNum == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (levelNum == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
