using System;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameEventString), editorForChildClasses: true)]
public class EventStringEditor : Editor
{
    string data;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEventString e = target as GameEventString;

        GUILayout.Label("Data to send - String");
        data = GUILayout.TextField(data);
        
        if (GUILayout.Button("Raise")){
            e.Raise(data);
        }
    }
}
