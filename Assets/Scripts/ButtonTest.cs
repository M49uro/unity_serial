using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonTest : MonoBehaviour
{
    private ConTest _gameInputs;

    // Start is called before the first frame update
    private void Awake()
    {
        _gameInputs = new ConTest();

        _gameInputs.Button.Circle.performed += OnCircleStart;
        _gameInputs.Button.Circle.canceled += OnCircleEnd;

        _gameInputs.Enable();
    }

    private void OnDestroy()
    {
        _gameInputs?.Dispose();
    }

    private void OnCircleStart(InputAction.CallbackContext context)
    {
        Debug.Log("100");
    }

    private void OnCircleEnd(InputAction.CallbackContext context)
    {
        Debug.Log("0");
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
