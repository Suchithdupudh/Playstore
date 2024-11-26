using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class User : IUser
    {
        //Properties 
        public int Id { get; set; }
        public string Name  { get; set; }
        public String Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }

        private int UserKey { get; set; }

        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void CreateUser()
        {
            Console.WriteLine("User Registration ");
            // how to read input from keyboard
            Console.Write("Enter Name");
            Name = Console.ReadLine();//read input
            Console.WriteLine("Welcome," + Name);
            Console.Write("Enter Mobile");
            Mobile =Convert.ToInt32 (Console.ReadLine());//read input
        }

        public void DeleteUser()
        {
            for (int i = 0; i < UserKey; i++);
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
