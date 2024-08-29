using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Bool Game Event", menuName = "Events/Game Event Bool", order = 52)]
public class GameEventBool : ScriptableObject
{

    private readonly List<GameEventBoolListener> eventListeners = new List<GameEventBoolListener>();

    public void Raise(bool data)
    {
        for(int i = eventListeners.Count -1; i >= 0; i--)
            eventListeners[i].OnEventRaised(data);
    }

    public void RegisterListener(GameEventBoolListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventBoolListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
