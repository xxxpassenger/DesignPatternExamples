using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class SingletonTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            SingletonA.Instance.DoSomething();
            SingletonB.Instance.DoSomething();
        }
    }
}

