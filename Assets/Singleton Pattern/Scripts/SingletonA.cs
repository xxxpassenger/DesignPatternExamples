using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class SingletonA : BaseSingleton<SingletonA>
    {
        public void DoSomething()
        {
            Debug.Log("SingletonA:DoSomething!");
        }
    }
}

