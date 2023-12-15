using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerStatesContext : MonoBehaviour
{
    public Transform homePosition;
    public Transform workPosition;
    public Transform worker;
    public float workerSpeed;
    public float workerTimeInStates;
    public float minDistanceToEnterNewState;
    private IState _state;

    private void Awake()
    {
        _state = new WorkerMovementToHomeState(this);
    }

    private void Update()
    {
        _state.Update();
    }

    public void ChangeState(IState newState)
    {
        _state.Exit();
        _state = newState;
        _state.Enter();
    }
}
