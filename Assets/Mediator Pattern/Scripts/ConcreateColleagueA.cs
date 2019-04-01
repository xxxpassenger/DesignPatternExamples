using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class ConcreateColleagueA : Colleague
    {
        public ConcreateColleagueA(Mediator mediator) : base(mediator){}

        public override void Request(string message)
        {
            Debug.Log("ConcreateColleagueA.Request:" + message);
        }

        public void Action()
        {
            mediator.SendMessenge(this,"ColleageA 发出通知！");
        }
    }
}

