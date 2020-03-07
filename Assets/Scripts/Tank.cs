using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    //public void OnFire(InputAction.CallbackContext context)
    //{
    //}

    //public void OnMove(InputAction.CallbackContext context)
    //{
    //    var value = context.ReadValue<Vector2>();
    //}

    
public void OnMove(InputValue value)
    {
        transform.Translate(value.Get<Vector2>().x, 0, 0);
    }

    public void OnFire()
    {
        Debug.Log("OnFire");
    }
}
