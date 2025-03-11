using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Policy_App_withSQL.Exceptions;
using Policy_App_withSQL.Models;
using System.Data.SqlClient;
using System.Data;
using Policy_App_withSQL.Utility;
using Policy_App_withSQL.Constant;

namespace Policy_App_withSQL.Repositories
{
    internal class PolicyRepository : IPolicyRepository
    {
        List<Policy> policies;
        // SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        string connstring;
        private List<Policy> policy;
        private PolicyType type;


        //constructor
        public PolicyRepository()
        {
            //sqlConnection = new SqlConnection("Server=DESKTOP-03V0C0BT;Database=InsuranceDB;Trusted_Connection=True");
            //comment the below line to execute stored procedures
            cmd = new SqlCommand();
            connstring = DbConnUtil.GetConnectionString();
        }

        public int AddPolicy(Policy policy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into Policies (PolicyHolderName,Type,StartDate,EndDate) values(@PolicyHolderName,@Type,@StartDate,@EndDate)";              
                cmd.Parameters.AddWithValue("@PolicyHolderName", policy.PolicyHolderName);
                cmd.Parameters.AddWithValue("@StartDate", policy.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", policy.EndDate);
                cmd.Parameters.AddWithValue("@Type", policy.Type);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
                // return cmd.ExecuteScalar();//check this method

            }
        }


      

        public int DeletePolicy(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.CommandText = "Delete from Policies where PolicyId=@PolicyId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PolicyId", id);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                var abc= cmd.ExecuteNonQuery();
                if (abc != 0) {
                    Console.WriteLine("ID daleted successfully");
                }
                return abc;
            }
        }



        public List<Policy> GetAllPolicies()

        {
            List<Policy> policies = new List<Policy>();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                #region Executing StoredProcedures with ADO.net
                //cmd = new SqlCommand("GetAllPolicies ");
                //cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                cmd.CommandText = "select * from Policies";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //create an object of PolicyClass
                    Policy policy = new Policy();
                    
                    policy.PolicyId = (int)reader["PolicyId"];
                     
                    policy.PolicyHolderName = (string)reader["PolicyHolderName"];
                     
                    policy.Type = (PolicyType)reader["Type"];
                    policy.StartDate = (DateTime)reader["StartDate"];
                    
                    policy.EndDate = (DateTime)reader["EndDate"];
                    
                    policies.Add(policy);

                }
            }
            return policies;
        }








        public Policy SearchPolicy(int id)
        {
            List<Policy> Policylist = GetAllPolicies();
            using(SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                var policy = Policylist.FirstOrDefault(p => p.PolicyId == id);
                if (policy == null)
                {
                    throw new PolicyNotFoundException($"Policy with Id {id} not found!");
                }
                cmd.CommandText = "select * from Policies where PolicyId=@PolicyId";
                cmd.Parameters.AddWithValue("@PolicyId", id);
                cmd.Connection = sqlConnection;

                sqlConnection.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Policy policyInfo = new Policy();
                    policyInfo.PolicyId = (int)reader["PolicyId"];

                    policyInfo.PolicyHolderName = (string)reader["PolicyHolderName"];

                    policyInfo.Type = (PolicyType)reader["Type"];
                    policyInfo.StartDate = (DateTime)reader["StartDate"];

                    policyInfo.EndDate = (DateTime)reader["EndDate"];
                    return policyInfo;
                }
                return null;
            }
        }

        public int UpdatePolicy(int id)
        {
            List<Policy>policyList=GetAllPolicies();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.CommandText = "Update Policies set PolicyHolderName=@PolicyHolderName, Type=@type,EndDate=@enddate where PolicyId=@PolicyId";
                if(!policyList.Any(p=>p.PolicyId==id))
                {
                    throw new PolicyNotFoundException($"Invalid ID{id}");
                }
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("enter policy type");
                PolicyType type = Enum.Parse<PolicyType>(Console.ReadLine());
                Console.WriteLine("enter EndDate");
                DateTime EndDate = DateTime.Parse(Console.ReadLine());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PolicyHolderName", name);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@PolicyId", id);

                Console.WriteLine("Policy Updated successfully.");

               cmd.Connection  = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
                //Console.WriteLine("Enter type");
                // PolicyType p = (PolicyType)Enum.Parse(typeof (PolicyType),Console.ReadLine(),true);
                //policy.Type = (PolicyType)type;
            }

        }

        //internal IEnumerable<object> GetAllPolicies()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
