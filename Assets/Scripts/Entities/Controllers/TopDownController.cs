using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); //direction을 넣어줘서 OnMoveEvent 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); 
    }
}
