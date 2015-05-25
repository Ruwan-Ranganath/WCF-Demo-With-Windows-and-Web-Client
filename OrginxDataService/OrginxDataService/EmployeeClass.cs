using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
    public class EmployeeClass
    {
       private int emp_ID;
 
       private string name;
       private int nic;      
       private string address;
       private int Mobile;
       private DateTime Birthday;
       private string position;       
       private int BasicSalary;
       private int bonus;
       private DateTime hiredate;
       private string department;
       private string sex;
       private int phoneno1;
       private int phoneno2;
       private string username;
       private string password;
       private int user_level;



       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       

       public string Address
       {
           get { return address; }
           set { address = value; }
       }

       public int Nic
       {
           get { return nic; }
           set { nic = value; }
       }

       public int Mobile1
       {
           get { return Mobile; }
           set { Mobile = value; }
       }
      

       public DateTime Birthday1
       {
           get { return Birthday; }
           set { Birthday = value; }
       }

       public string Position
       {
           get { return position; }
           set { position = value; }
       }
    

       public int BasicSalary1
       {
           get { return BasicSalary; }
           set { BasicSalary = value; }
       }
      

       public int Bonus
       {
           get { return bonus; }
           set { bonus = value; }
       }
      

       public DateTime Hiredate
       {
           get { return hiredate; }
           set { hiredate = value; }
       }
      

       public string Department
       {
           get { return department; }
           set { department = value; }
       }
       private string userimage;

       public string Userimage
       {
           get { return userimage; }
           set { userimage = value; }
       }
       

       public string Sex
       {
           get { return sex; }
           set { sex = value; }
       }
       

       public int Phoneno1
       {
           get { return phoneno1; }
           set { phoneno1 = value; }
       }
      

       public int Phoneno2
       {
           get { return phoneno2; }
           set { phoneno2 = value; }
       }
        public int Emp_ID
        {
            get { return emp_ID; }
            set { emp_ID = value; }
        }
        

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public int User_level
        {
            get { return user_level; }
            set { user_level = value; }
        }


    }
}
