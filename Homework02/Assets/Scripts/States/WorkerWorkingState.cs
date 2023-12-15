using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerWorkingState : IState
{
    private WorkerStatesContext _workerStatesContext;
    private float _timer;

    public WorkerWorkingState(WorkerStatesContext context)
    {
        _workerStatesContext = context;
        _timer = _workerStatesContext.workerTimeInStates;
    }

    public void Enter()
    {
        Debug.Log("I`m fishing");
    }

    public void Exit()
    {
        Debug.Log("Time to go home!");
    }

    public void Update()
    {
        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
        }
        else
        {
            _workerStatesContext.ChangeState(new WorkerMovementToHomeState(_workerStatesContext));
        }
    }
}
