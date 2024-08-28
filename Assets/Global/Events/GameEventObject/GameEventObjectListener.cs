using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CustomGameEvent : UnityEvent<Component, object> { }
public class GameEventObjectListener : MonoBehaviour
{
    public GameEventObject Event;

    public CustomGameEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(Component sender, object data)
    {
        Response.Invoke(sender, data);
    }

}
