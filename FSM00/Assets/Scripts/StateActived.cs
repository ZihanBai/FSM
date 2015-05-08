using UnityEngine;

namespace Assets.Scripts
{
    public class StateActived:State
    {
        public override void Execute(Troll troll)
        {
            Debug.Log("Actived");
            if (troll.CanAttack())
            {
                troll.ChangeState(new StateAttack());
            }
        }
    }
}
