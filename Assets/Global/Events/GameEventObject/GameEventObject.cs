using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Game Object Event", menuName = "Events/Game Event Object", order = 52)]
public class GameEventObject : ScriptableObject
{

    private readonly List<GameEventObjectListener> eventListeners = new List<GameEventObjectListener>();

    public void Raise(Component sender, object data)
    {
        for(int i = eventListeners.Count -1; i >= 0; i--)
            eventListeners[i].OnEventRaised(sender,data);
    }

    public void RegisterListener(GameEventObjectListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventObjectListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
