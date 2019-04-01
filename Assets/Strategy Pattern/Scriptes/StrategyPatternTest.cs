using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DesignPattern
{
    public class StrategyPatternTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Swan swan = new Swan();
            swan.SetMoveStategy(new MoveStategySwim());
            swan.Move();
            swan.SetMoveStategy(new MoveStrategyFly());
            swan.Move();
            swan.SetMoveStategy(new MoveStrategyRun());
            swan.Move();       
        }
    }
}

