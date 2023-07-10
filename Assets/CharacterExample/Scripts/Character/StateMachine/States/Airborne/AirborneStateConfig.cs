using System;
using UnityEngine;

[Serializable]
public class AirborneStateConfig
{
    [SerializeField] private float _speed;
    [SerializeField] private JumpingStateConfig _jumpingStateConfig;

    public float Speed => _speed;
    public JumpingStateConfig JumpingStateConfig => _jumpingStateConfig;

    public float BaseGravity 
        => 2f * _jumpingStateConfig.MaxHeight / (_jumpingStateConfig.TimeToReachMaxHeight * _jumpingStateConfig.TimeToReachMaxHeight);
}
