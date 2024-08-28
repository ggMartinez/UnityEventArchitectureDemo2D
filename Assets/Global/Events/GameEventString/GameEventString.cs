using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New String Game Event", menuName = "Events/Game Event String", order = 52)]
public class GameEventString : ScriptableObject
{

    private readonly List<GameEventStringListener> eventListeners = new List<GameEventStringListener>();

    public void Raise(string data)
    {
        for(int i = eventListeners.Count -1; i >= 0; i--)
            eventListeners[i].OnEventRaised(data);
    }

    public void RegisterListener(GameEventStringListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventStringListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
