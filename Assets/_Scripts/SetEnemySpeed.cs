using UnityEngine;
using UnityEngine.AI;

using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using Pada1.BBCore.Framework; // BasePrimitiveAction

[Action("MyActions/SetEnemySpeed")]
public class SetEnemySpeed : BasePrimitiveAction
{
    [InParam("enemySpeed", DefaultValue = 2f)]
    public float enemySpeed;

    [InParam("enemyAnimator")]
    public Animator enemyAnimator;

    [InParam("enemyNavMeshAgent")]
    public NavMeshAgent enemyNavMeshAgent;

    public override TaskStatus OnUpdate()
    {
        enemyNavMeshAgent.speed = enemySpeed;
        enemyAnimator.SetFloat("Speed", enemySpeed);
        enemyAnimator.SetFloat("MotionSpeed", 1);
        return TaskStatus.COMPLETED;
    }

    public void OnFootstep()
    {
        // Add your logic here for what should happen on a footstep.
    }
}
