using System;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(GameEventBool), editorForChildClasses: true)]
public class EventBoolEditor : Editor
{
    bool data;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEventBool e = target as GameEventBool;

        GUILayout.Label("Data to send - Bool");
        data = GUILayout.Toggle(data, "");
        
        if (GUILayout.Button("Raise")){
            e.Raise(data);
        }
    }
}
