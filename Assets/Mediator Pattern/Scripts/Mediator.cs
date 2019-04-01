using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public abstract class Mediator
    {
        public abstract void SendMessenge(Colleague theColleague, string message);
    }
}

