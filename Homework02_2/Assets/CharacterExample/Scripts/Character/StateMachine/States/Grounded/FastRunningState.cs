using UnityEngine.InputSystem;

public class FastRunningState : RunningState
{
    private readonly FastRunningStateConfig _config;

    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.FastRunningStateConfig;

    public override void Enter()
    {
        base.Enter();
        Data.Speed = _config.Speed;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();

        Input.Movement.FastRun.canceled += OnFastRunKeyUnpressed;
    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.FastRun.canceled -= OnFastRunKeyUnpressed;
    }

    private void OnFastRunKeyUnpressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<RunningState>();
}
