using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpHandler 
{
    int currentLevel ;
    float currentExperience;
    float maxExperience ;

    public int CurrentLevel 
    {
        get { return currentLevel; }

        private set { currentLevel = value; }   
    
    }
    public float MaxExperience
    {
        get { return maxExperience; }
       private set { maxExperience = value; }

    }

    public float CurrentExperience
    {
        get { return currentExperience; }
        private set { currentExperience = Mathf.Clamp(value, 0f, maxExperience); }

    }

    public void GainExperience(float experienceToAdd) 
    { 
      currentExperience += experienceToAdd;
        if (currentExperience >= maxExperience)
        {

            LevelUp();
        }    
    }
    public void LevelUp()
    {
        currentLevel++;
        currentExperience = 0f;
        maxExperience *= 1.5f; //Increase max Experience by 50% on each level
        //Add SkillPoints
        //Add StatPoints
    }
}

