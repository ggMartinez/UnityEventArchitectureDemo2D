using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class StringGameEvent : UnityEvent<string> { }
public class GameEventStringListener : MonoBehaviour
{
    public GameEventString Event;

    public StringGameEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(string data)
    {
        Response.Invoke(data);
    }

}
