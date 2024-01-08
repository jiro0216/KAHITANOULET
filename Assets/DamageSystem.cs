using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class DamageSystem 
{

    int damage_Vandal = 150;
    int damage_Sheriff = 75;
    int damage_Operator = 200;
   
    public int Damage_Vandal
    {
        get { return damage_Vandal; }
        set { damage_Vandal = value; }
    }

    public int Damage_Sheriff {
        get { return damage_Sheriff; }
        set { damage_Sheriff = value; }
    }

    public int Damage_Operator {
        get { return damage_Operator; }
        set { damage_Operator = value; }
    }

   
  
}

public class PowerUps {

    //Base Damage PowerUp
    float feedingFrenzy = 20;
    public float Feeding_Frenzy {

        get { return feedingFrenzy; }
        set { feedingFrenzy = value; }
    }
    //Percentage Damage PowerUp

    float wellFed = 30;

    public float Well_Fed {

        get { return wellFed; }
        set { wellFed = value; }
    }
}

