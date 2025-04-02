using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;
    public float delay;

    private void Awake()
    {
        Invoke("InvokeDelayedStart", delay);
        
        GameStart.Invoke();
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public UnityEvent GameStart, DelayedStart;
    public UnityEvent BananaTappedEvent, BombTappedEvent;
    public event Action OnBananaTapped;
    public event Action OnBombTapped;

    void InvokeDelayedStart()
    {
        // Invoke the Unity event
        if (DelayedStart != null)
        {
            DelayedStart.Invoke();
        }
    }

    public void BananaTapped()
    {
        OnBananaTapped?.Invoke();
    }

    public void BombTapped()
    {
        OnBombTapped?.Invoke();
    }
}
