using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int pointsPerLevel = 200;
     private int experiencePoints = 0;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
        
    } 

    public void GainExperience(int points)
    {
        experiencePoints += points;
    }

    public int GetExperience()
    {
        return experiencePoints;
    }

    public int Getlevel()
    {
        return experiencePoints / pointsPerLevel;
    }


}
