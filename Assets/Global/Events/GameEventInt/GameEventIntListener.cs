using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntGameEvent : UnityEvent<int> { }
public class GameEventIntListener : MonoBehaviour
{
    public GameEventInt Event;

    public IntGameEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(int data)
    {
        Response.Invoke(data);
    }

}
