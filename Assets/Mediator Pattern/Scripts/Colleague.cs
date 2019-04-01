using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public abstract class Colleague
    {
        protected Mediator mediator = null;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Request(string message);
    }
}

