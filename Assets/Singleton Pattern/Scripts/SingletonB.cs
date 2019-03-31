using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class SingletonB : BaseSingleton<SingletonB>
    {
        public void DoSomething()
        {
            Debug.Log("SingletonB:DoSomething!");
        }
    }
}

