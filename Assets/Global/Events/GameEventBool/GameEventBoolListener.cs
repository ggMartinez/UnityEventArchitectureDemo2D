using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class BoolGameEvent : UnityEvent<bool> { }
public class GameEventBoolListener : MonoBehaviour
{
    public GameEventBool Event;

    public BoolGameEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(bool data)
    {
        Response.Invoke(data);
    }

}
