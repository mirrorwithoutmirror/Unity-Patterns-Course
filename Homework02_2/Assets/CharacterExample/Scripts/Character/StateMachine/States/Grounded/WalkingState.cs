using UnityEngine.InputSystem;

public class WalkingState : RunningState
{
    private readonly WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.WalkingStateConfig;

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

        Input.Movement.Walk.canceled += OnWalkKeyUnpressed;
    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();

        Input.Movement.Walk.canceled -= OnWalkKeyUnpressed;
    }

    private void OnWalkKeyUnpressed(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<RunningState>();
}
