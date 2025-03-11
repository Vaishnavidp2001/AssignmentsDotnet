using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Policy_App_withSQL.Models;

namespace Policy_App_withSQL.Repositories
{
    internal interface IPolicyRepository
    {
        public int AddPolicy(Policy policy);
        public List<Policy> GetAllPolicies();
        public Policy SearchPolicy(int id);
        public int UpdatePolicy(int id);
        public int DeletePolicy(int id);
        //public List<Policy> GetActivePolicies();
    }
}
