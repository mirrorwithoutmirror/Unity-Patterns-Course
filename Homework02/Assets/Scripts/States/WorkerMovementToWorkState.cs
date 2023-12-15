using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerMovementToWorkState : IState
{
    private WorkerStatesContext _workerStatesContext;
    private Transform _worker;
    private Transform _target;
    private float _speed;
    private float _distance;

    public WorkerMovementToWorkState(WorkerStatesContext context)
    {
        _workerStatesContext = context;
        _worker = _workerStatesContext.worker;
        _target = _workerStatesContext.workPosition;
        _speed = _workerStatesContext.workerSpeed;
        _distance = _workerStatesContext.minDistanceToEnterNewState;
    }

    public void Enter()
    {
        Debug.Log("Going to fishing");
    }

    public void Exit()
    {
        Debug.Log("Let`s start fishing!");
    }

    public void Update()
    {
        if (Vector3.Distance(_worker.position, _target.position) > _distance)
        {
            _worker.position = Vector3.Lerp(_worker.position, _target.position, _speed * Time.deltaTime);
        }
        else
        {
            _workerStatesContext.ChangeState(new WorkerWorkingState(_workerStatesContext));
        }
    }
}
