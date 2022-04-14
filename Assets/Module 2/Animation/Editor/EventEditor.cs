using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AnimationEventTest))]
public class EventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        AnimationEventTest animationEventTest = (AnimationEventTest)target;


        if (GUILayout.Button("Play Sound"))
        {
            Debug.Log("Character is now playing the move animation");
            animationEventTest.StepsSound();
        }

        

    }
}
