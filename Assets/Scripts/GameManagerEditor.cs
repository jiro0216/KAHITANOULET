using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameManager)), CanEditMultipleObjects]

public class GameManagerEditor : Editor {

    // Start is called before the first frame update
    public override void OnInspectorGUI() 
    {
        DrawDefaultInspector();
        GameManager GameManager = (GameManager)target;
        if (GUILayout.Button("FeedingFrenzy")) 
        {
            GameManager.DamagePowerUp_FeedingFrenzy();

        }

        if (GUILayout.Button("WellFed")) {
            GameManager.DamagePowerUp_WellFed();

        }

        if (GUILayout.Button("Reset")) {
            GameManager.ResetValues();

        }

        if (GUILayout.Button("Exp"))
        {
            GameManager.AddEXP(GameManager.EXP_to_Add);

        }
    }
    
}
