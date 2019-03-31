using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class BankAccountFacadeTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            BankAccountFacade bank = new BankAccountFacade(123456789, 123456);

            Debug.Log("我想要取出500元。");
            bank.WithdrawCash(500);

            Debug.Log("我想要取出5000元。");
            bank.WithdrawCash(5000);

            Debug.Log("我想要存入300元。");
            bank.DepositCash(300);
        }
    }
}

