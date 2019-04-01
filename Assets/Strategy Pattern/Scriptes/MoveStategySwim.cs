using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class MoveStategySwim : IMoveStrategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("移动策略：游动");
        } 
    }
}

