using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Mail;

namespace OrginxDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OriginxDataService" in both code and config file together.
    public class OriginxDataService : IOriginxDataService,IEmployeeService,ICustomerService,IEmailService,IWorlWideBranchService,ILocalBranchService,IItemDeliveryService,ILoginService
    {

       
        // This getMessage is just for testing if any bug comeup with WCF
        public string getMessage(string name)
        {
            return "Hello " + name;
        }
                

        // Add new Customer with stored proceedure and linq 
        public void AddCustomer(CustomerClass Customer)
        {
            try
            {
                var AddCustomer = new OriginXLinqDataContext();
                AddCustomer.addCustomer(
                    Customer.Name,
                    Customer.Address,
                    Customer.Type,
                    Customer.Phoneno1,
                    Customer.Phoneno2,
                    Customer.Clientlogo,
                    Customer.Additionalinfo
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Read();
            }

        }


        public void DeleteCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }

        public void SearchCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }



        public bool SendMail(string emailTo, string subject, string body, bool isBodyHtml)
        {
            if (string.IsNullOrEmpty(emailTo))
            {
                return false;
            }
            using (SmtpClient smtpClient = new SmtpClient())
            {
                using (MailMessage message = new MailMessage())
                {
                    message.Subject = subject == null ? "" : subject;
                    message.Body = body == null ? "" : body;
                    message.IsBodyHtml = isBodyHtml;
                    message.To.Add(new MailAddress(emailTo));
                    try
                    {
                        smtpClient.Send(message);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new FaultException(ex.Message);
                    }

                }
            }
        }

        public void AddWorldWideBranch(WorldWideBranchClass WorldWideBranch)
        {
            try
            {
                var addworldbranch = new OriginXLinqDataContext();
                addworldbranch.addWorldOffice(
                    WorldWideBranch.Officename,
                    WorldWideBranch.Officecountry,
                    WorldWideBranch.Officeadmin,
                    WorldWideBranch.Officedesc
                    );
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Read();
            }
        }

        public void addlocalbranch(LocalBranchClass LB)
        {
            try
            {
                var localbranch = new OriginXLinqDataContext();
                localbranch.addCountryBranch(
                    LB.Countrybranchcod,
                    LB.Branchadmin,
                    LB.Branchadmin,
                    LB.Branchdesc
                    );
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Read();
            }
        }

        public void addEmployee(EmployeeClass emp)
        {
            var addemps = new OriginXLinqDataContext();
            addemps.newemployees(
                        emp.Name,
                        emp.Nic,
                        emp.Mobile1,
                        emp.Address,
                        emp.Position,
                        emp.BasicSalary1,
                        emp.Bonus,
                        emp.Userimage,   
                        emp.Hiredate,
                        emp.Department,  
                        emp.Birthday1,
                        emp.Sex,
                        emp.Phoneno1,
                        emp.Phoneno2,
                        emp.Username,
                        emp.Password,
                        emp.User_level
                );

        }

        public void addDelivery(ItemDeliveryClass delivery)
        {
            var adddelivery = new OriginXLinqDataContext();
            adddelivery.adddelivery(
                delivery.DeliveryId,
                delivery.SendClietnId,
                delivery.RecieveClientId,
                delivery.StartDate,
                delivery.SendDate,
                delivery.EndDate,
                delivery.LocalBranch,
                delivery.WorldBranch,
                delivery.SalesPerson,
                delivery.DeliveryPerson
                );

        }

        public bool login(string username, string password)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=RANGANATH;Initial Catalog=OriginXDB;Integrated Security=True";
            con.Open(); 

             SqlCommand cmd = new SqlCommand("select username,password from employee where username='" + username + "'and password='" +  password + "'", con);  

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close(); 
        }
    }
}
