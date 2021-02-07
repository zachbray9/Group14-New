using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public static int health = 2000;
    public static int points = 0;

    public Text healthText;
    public Text pointsText;


    // Start is called before the first frame update
    void Start()
    {

        //health = 2000;
        //points = 0;

    }

    // Update is called once per frame
    void Update()
    {
        setHealthText();
        setPointsText();
    }

    void setHealthText()
    {
        healthText.text = "Health\n" + health.ToString();
    }

    public void loseHealth(int damage)
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
