using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustInfoLogMethods
    {
        CustUserEntities context = null;
        public CustInfoLogMethods()
        {
            context = new CustUserEntities();
        }
        public List<CustLogInfo> GetCustLogInfos()
        {
            return context.CustLogInfoes.ToList();
        }
        public bool SaveCustLog(CustLogInfo t)
        {
            try
            {
                context.CustLogInfoes.Add(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public class UserInfomethods
    {
        CustUserEntities user = null;
        public UserInfomethods()
        {
            user = new CustUserEntities();
        }
        public UserInfo Checklogin(int kp, string p)
        {
            UserInfo k = null;
            foreach (var item in user.UserInfoes.ToList())
            {
                if (kp == item.UserId && p == item.Password)
                {
                    k = item;
                }
            }
            return k;
        }
    }
}