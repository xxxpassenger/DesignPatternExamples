using UnityEngine;
using System.Collections;

namespace DesignPattern
{

    public interface HeroBaseState
    {
        void OnStateEnter();
        void Execute();
        void OnStateExit();
        void HandleInput();
    }
}
