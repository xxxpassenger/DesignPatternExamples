using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class StatePatternTest : MonoBehaviour
    {

        private Hero hero;
        // Start is called before the first frame update
        void Start()
        {
            hero = new Hero();
        }

        // Update is called once per frame
        void Update()
        {
            hero.Update();
        }
    }
}

