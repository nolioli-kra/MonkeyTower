using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    private void Awake()
    {
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
    public UnityEvent GameStart;
    public UnityEvent BananaTappedEvent, BombTappedEvent;
    public event Action OnBananaTapped;
    public event Action OnBombTapped;

    public void BananaTapped()
    {
        OnBananaTapped?.Invoke();
    }

    public void BombTapped()
    {
        OnBombTapped?.Invoke();
    }
}
