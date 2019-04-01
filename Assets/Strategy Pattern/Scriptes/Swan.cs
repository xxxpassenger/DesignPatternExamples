using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DesignPattern
{
    public class Swan
    {
        private IMoveStrategy moveStrategy = null;

        public void SetMoveStategy(IMoveStrategy moveStrategy)
        {
            this.moveStrategy = moveStrategy;
        }

        public void Move()
        {
            Debug.Log("天鹅移动");
            moveStrategy.AlgorithmInterface();
        }
    }
}

