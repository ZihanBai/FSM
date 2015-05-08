using UnityEngine;

namespace Assets.Scripts
{
    public class Troll : MonoBehaviour
    {

        private State mCurrentState;

        private bool isActived = false;

        private bool canAttack = false;

        private bool isDead = false;

        void Awake()
        {
            mCurrentState = new StateIdle();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                isActived = true;
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                canAttack = true;
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                isDead = true;
            }
            mCurrentState.Execute(this);
        }

        public void ChangeState(State newState)
        {
            mCurrentState = newState;
        }

        public bool IsActived()
        {
            return isActived;
        }

        internal bool CanAttack()
        {
            return canAttack;
        }

        internal bool IsDead()
        {
            return isDead;
        }

        internal void Dead()
        {
            Destroy(this.gameObject);
        }
    }
}
