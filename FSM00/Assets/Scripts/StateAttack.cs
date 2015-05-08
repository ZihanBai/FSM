using UnityEngine;

namespace Assets.Scripts
{
    public class StateAttack:State
    {
        public override void Execute(Troll troll)
        {
            Debug.Log("Attack");
            if (troll.IsDead())
            {
                troll.ChangeState(new StateDead());
            }
        }
    }
}
