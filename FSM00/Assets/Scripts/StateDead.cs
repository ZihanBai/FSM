using UnityEngine;

namespace Assets.Scripts
{
    public class StateDead:State
    {
        public override void Execute(Troll troll)
        {
            Debug.Log("Dead");
            troll.Dead();
        }
    }
}
