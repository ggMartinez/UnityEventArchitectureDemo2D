using System;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameEventInt), editorForChildClasses: true)]
public class EventIntEditor : Editor
{
    string data;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEventInt e = target as GameEventInt;

        GUILayout.Label("Data to send - int");
        data = GUILayout.TextField(data);
        
        if (GUILayout.Button("Raise")){
            e.Raise(System.Convert.ToInt32(data));
        }
    }
}

