using UnityEngine;

namespace Assets.Scripts
{
    public class StateIdle:State
    {
        public override void Execute(Troll troll)
        {
            Debug.Log("Idle");
            if (troll.IsActived())
            {
                troll.ChangeState(new StateActived());
            }
        }
    }
}
