using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class WorkerMovementToHomeState : IState
{
    private WorkerStatesContext _workerStatesContext;
    private Transform _worker;
    private Transform _target;
    private float _speed;
    private float _distance;

    public WorkerMovementToHomeState(WorkerStatesContext context)
    {
        _workerStatesContext = context;
        _worker = _workerStatesContext.worker;
        _target = _workerStatesContext.homePosition;
        _speed = _workerStatesContext.workerSpeed;
        _distance = _workerStatesContext.minDistanceToEnterNewState;
    }

    public void Enter()
    {
        Debug.Log("Going to home.");
    }

    public void Exit()
    {
        Debug.Log("Time to have a rest!");
    }

    public void Update()
    {
        if (Vector3.Distance(_worker.position, _target.position) > _distance)
        {
            _worker.position = Vector3.Lerp(_worker.position, _target.position, _speed * Time.deltaTime);
        }
        else
        {
            _workerStatesContext.ChangeState(new WorkerRestingState(_workerStatesContext));
        }
    }
}
