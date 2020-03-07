using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    private void Awake()
    {
        m_inputSystem = GetComponent<PlayerInput>();
        //m_inputSystem.enabled = false;
    }


    public void OnMove(InputValue value)
    {
        transform.Translate(value.Get<Vector2>().x, 0, 0);
    }

    public void OnFire()
    {
        Debug.Log("OnFire");
    }

    internal void EnableInput()
    {
        m_inputSystem.enabled = true;
    }

    public PlayerInput m_inputSystem;
}
