using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Int Game Event", menuName = "Events/Game Event Int", order = 52)]
public class GameEventInt : ScriptableObject
{

    private readonly List<GameEventIntListener> eventListeners = new List<GameEventIntListener>();

    public void Raise(int data)
    {
        for(int i = eventListeners.Count -1; i >= 0; i--)
            eventListeners[i].OnEventRaised(data);
    }

    public void RegisterListener(GameEventIntListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventIntListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
