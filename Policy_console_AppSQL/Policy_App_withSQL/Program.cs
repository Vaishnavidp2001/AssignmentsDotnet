using Policy_App_withSQL.Constant;
using Policy_App_withSQL.Models;
using Policy_App_withSQL.Repositories;

namespace Policy_App_withSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolicyRepository repo = new PolicyRepository();
            bool result = true;
            while (result)
            {
                Console.WriteLine("=======Insurance Policy Menu=======");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2. View all Policies");
                Console.WriteLine("3. Search Policy by Id");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                //Console.WriteLine("6. View active Policies");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            
                            Console.Write("Policy Holder name: ");
                            string name = Console.ReadLine();
                            Console.Write("Policy type(Life/Health/Vehicle/Property): ");
                            PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());
                            Console.Write("Start Date(yyyy-mm-dd): ");
                            DateTime start = DateTime.Parse(Console.ReadLine());
                            Console.Write("End Date(yyyy-mm-dd): ");
                            DateTime end = DateTime.Parse(Console.ReadLine());

                            int addPolicy=repo.AddPolicy(new Policy {PolicyHolderName=name,Type=type,StartDate=start,EndDate=end});
                            if (addPolicy>0)
                            {
                                Console.WriteLine("Added");
                            }
                            break;

                    case 2:
                        foreach (var p in repo.GetAllPolicies())
                        {
                            Console.WriteLine(p);
                        }
                        break;

                    case 3:
                        Console.Write("Enter Policy Id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(repo.SearchPolicy(searchId));
                        break;

                    case 4:
                        Console.Write("Enter Polidy Id: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                       
                        int update = repo.UpdatePolicy(updateId);
                        break;

                    case 5:
                        Console.WriteLine("Enter Policy Id: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        repo.DeletePolicy(deleteId);
                        break;

                    //case 6:
                    //    foreach (var active in repo.GetAllPolicies())
                    //    {
                    //        Console.WriteLine(active);
                    //    }
                    //    break;

                    case 7:
                        result = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Option!");
                            break;
                    }
                }
                
            }
        }
    }

