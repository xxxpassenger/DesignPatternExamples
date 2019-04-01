using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class ConcreateMediator : Mediator
    {
        ConcreateColleagueA colleagueA = null;
        ConcreateColleagueB colleagueB = null;

        public override void SendMessenge(Colleague colleague, string message)
        {
            if (colleague == colleagueA)
            {
                colleagueB.Request(message);
            }
            else if (colleague == colleagueB)
            {
                colleagueA.Request(message);
            }
        }


        public void SetColleagueA(ConcreateColleagueA colleagueA)
        {
            this.colleagueA = colleagueA;
        }

        public void SetColleagueB(ConcreateColleagueB colleagueB)
        {
            this.colleagueB = colleagueB;
        }
    }
}

