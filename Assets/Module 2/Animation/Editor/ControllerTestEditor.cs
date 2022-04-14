using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ControllerTest))]
public class ControllerTestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ControllerTest controllerTest = (ControllerTest)target;


        if (GUILayout.Button("Play Moving"))
        {
            Debug.Log("Character is now playing the move animation");
            controllerTest.StartMoving();
        }

        if (GUILayout.Button("Play Idle"))
        {
            Debug.Log("Character is now playing the idle animation");
            controllerTest.StopMoving();
        }

        if (GUILayout.Button("Play Shoot"))
        {
            Debug.Log("Character is now playing the shoot animation");
            controllerTest.Shoot();
        }

    }
}
