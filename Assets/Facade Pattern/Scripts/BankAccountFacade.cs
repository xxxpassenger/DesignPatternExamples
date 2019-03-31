using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;
        AcccountNumberCheck accChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChercker;
        WelcomToBank bankWelcomer;


        public BankAccountFacade(int accountNumber, int securityCode)
        {
            this.accountNumber = accountNumber;
            this.securityCode = securityCode;
            bankWelcomer = new WelcomToBank();
            accChecker = new AcccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChercker = new FundsCheck();
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public void WithdrawCash(double cash)
        {
            if (accChecker.AccountActive(GetAccountNumber())
                && codeChecker.IsSecurityCodeCorrect(GetSecurityCode())
                && fundChercker.HaveEnoughMoney(cash))
            {
                fundChercker.WithdrawMoney(cash);
                Debug.Log("交易完成！");
            }
            else
            {
                Debug.Log("交易失败");
            }
        }

        public void DepositCash(double cash)
        {
            if (accChecker.AccountActive(GetAccountNumber())
                && codeChecker.IsSecurityCodeCorrect(GetSecurityCode()))
            {
                fundChercker.MakeDeposit(cash);
                Debug.Log("交易完成！");
            }
            else
            {
                Debug.Log("交易失败！");
            }
        }
    }

    public class WelcomToBank
    {
        public WelcomToBank()
        {
            Debug.Log("欢迎来到xxx银行！");
            Debug.Log("很高兴能为你服务！");
        }
    }

    public class AcccountNumberCheck
    {
        private int accountNumber = 123456789;

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public bool AccountActive(int accountNum)
        {
            if (accountNum == accountNumber)
            {
                return true;
            }
            else
                return false;
        }
    }

    public class SecurityCodeCheck
    {
        private int securityCode = 123456;

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public bool IsSecurityCodeCorrect(int code)
        {
            if (code == securityCode)
                return true;
            else
                return false;
        }
    }

    public class FundsCheck
    {
        private double cashInAccount = 1000.00;
        public double GetCashInAccount()
        {
            return cashInAccount;
        }

        protected void DecreaseCashInAccount(double cash)
        {
            cashInAccount -= cash;
        }

        protected void IncreaseCashInAccount(double cash)
        {
            cashInAccount += cash;
        }

        public bool HaveEnoughMoney(double cashToWithdraw)
        {
            if (cashToWithdraw > GetCashInAccount())
            {
                Debug.Log("您卡里没有这么多钱！");
                return false;
            }
            else
                return true;
        }

        public void MakeDeposit(double cash)
        {
            IncreaseCashInAccount(cash);
            Debug.Log("存钱成功！，当前余额是：" +GetCashInAccount());
        }


        public void WithdrawMoney(double cash)
        {
            DecreaseCashInAccount(cash);
            Debug.Log("取钱成功！，当前余额是：" + GetCashInAccount());
        }
    }


}
