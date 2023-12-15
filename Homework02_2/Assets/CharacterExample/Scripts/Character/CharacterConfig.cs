using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private FastRunningStateConfig _fastRunningStateConfig;
    [SerializeField] private WalkingStateConfig _walkingStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;

    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public FastRunningStateConfig FastRunningStateConfig => _fastRunningStateConfig;
    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
}
