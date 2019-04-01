using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class MediatorTest : MonoBehaviour
    {
        ConcreateMediator mediator = new ConcreateMediator();
        void Start()
        {
            ConcreateColleagueA colleagueA = new ConcreateColleagueA(mediator);
            ConcreateColleagueB colleagueB = new ConcreateColleagueB(mediator);

            mediator.SetColleagueA(colleagueA);
            mediator.SetColleagueB(colleagueB);

            colleagueA.Action();
            colleagueB.Action();
        }
    }
}

