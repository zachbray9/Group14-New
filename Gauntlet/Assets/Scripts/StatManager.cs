using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public static float health = 2001f;
    public static int points = 0;

    public Text healthText;
    public Text pointsText;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }



    // Start is called before the first frame update
    void Start()
    {
        completeLevelUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        setHealthText();
        setPointsText();
        loseHealth(1 * Time.deltaTime);
        
    }

    void setHealthText()
    {
        healthText.text = "Health\n" + ((int)health).ToString();
    }

    public void loseHealth(float damage)
    {
        health -= damage;
    }

    void setPointsText()
    {
        pointsText.text = "Points\n" + points.ToString();
    }

    public void getPoints(int pointsGained)
    {
        points += pointsGained;
    }

}
