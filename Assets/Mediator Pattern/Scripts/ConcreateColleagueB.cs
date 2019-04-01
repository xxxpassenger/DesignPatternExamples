using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class ConcreateColleagueB : Colleague
    {
        public ConcreateColleagueB(Mediator mediator) : base(mediator) { }
        public override void Request(string message)
        {
            Debug.Log("ConcreateColleagueB.Request:" + message);
        }

        public void Action()
        {
            mediator.SendMessenge(this, "ColleageB 发出通知！");
        }
    }
}

