using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    internal class CurrentAccount : Account
    {
        public void Withdrawal ()
        {
            if (isWithdrawalValid & withdrawal < Balance)
            {
                Balance -= withdrawal - (withdrawal * 0.05);
            }
        }
    }
}