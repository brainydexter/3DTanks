using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class ITank : MonoBehaviour
{
    public abstract void GiveTurn();
}

public class Tank : ITank
{
    public void OnMove(InputValue value)
    {
        if(IsMyTurn)
        {
            transform.Translate(value.Get<Vector2>().x, 0, 0);
        }
    }

    public override void GiveTurn()
    {
        IsMyTurn = true;
    }

    #region Members

    public bool IsMyTurn { get; private set; }

    #endregion
}
