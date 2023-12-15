using UnityEngine;
using UnityEngine.InputSystem;

public class RunningState : GroundedState
{
    private readonly RunningStateConfig _config;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.FastRun.started += OnFastRunKeyPressed;
        Input.Movement.Walk.started += OnWalkKeyPressed;
    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.FastRun.started -= OnFastRunKeyPressed;
        Input.Movement.Walk.started -= OnWalkKeyPressed;
    }

    private void OnFastRunKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<FastRunningState>();
    private void OnWalkKeyPressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<WalkingState>();
}
