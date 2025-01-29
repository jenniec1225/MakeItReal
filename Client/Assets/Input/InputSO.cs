using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/InputSO", fileName = "InputSO")]
public class InputSO : ScriptableObject
{
    public InputSystem InputSystem;

    public UnityAction<Vector2> moveAction;
    public UnityAction<Vector2> lookAction;

    private void OnEnable()
    {
        InputSystem = new InputSystem();
        InputSystem.InGame.Enable();

        InputSystem.InGame.Move.performed += ctx => moveAction.Invoke(ctx.ReadValue<Vector2>());

        InputSystem.InGame.Move.canceled += ctx => moveAction?.Invoke(Vector2.zero);

        //입력마우스

        InputSystem.InGame.Look.performed += ctx => lookAction.Invoke(ctx.ReadValue<Vector2>());
        InputSystem.InGame.Look.canceled += ctx => lookAction.Invoke(Vector2. zero);

    }

    private void OnDisable()
    {
        InputSystem.InGame.Move.performed -= ctx => moveAction.Invoke(ctx.ReadValue<Vector2>());

        InputSystem.InGame.Move.canceled -= ctx => moveAction?.Invoke(Vector2.zero);

        InputSystem.InGame.Look.performed -= ctx => lookAction.Invoke(ctx.ReadValue<Vector2>());

        InputSystem.InGame.Disable();
    }

}
