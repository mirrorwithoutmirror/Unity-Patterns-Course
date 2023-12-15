using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerRestingState : IState
{
    private WorkerStatesContext _workerStatesContext;
    private float _timer;

    public WorkerRestingState(WorkerStatesContext context)
    {
        _workerStatesContext = context;
        _timer = _workerStatesContext.workerTimeInStates;
    }

    public void Enter()
    {
        Debug.Log("I`m sleeping");
    }

    public void Exit()
    {
        Debug.Log("Time to go fishing");
    }

    public void Update()
    {
        if (_timer > 0f)
        {
            _timer -= Time.deltaTime;
        }
        else
        {
            _workerStatesContext.ChangeState(new WorkerMovementToWorkState(_workerStatesContext));  
        }
    }
}
