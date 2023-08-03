using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment.cs
{
    // Creating Employee class
    public class Employee
    {
        // Creating Id, FirstName, and LastName properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isEqual = false;
            if (employee1.Id == employee2.Id)
            {
                isEqual = true;
            }
            return isEqual;
        }
        // Overloading the "!=" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool isNotEqual = false;
            if (employee1.Id != employee2.Id)
            {
                isNotEqual = true;
            }
            return isNotEqual;
        }

        //public static Game operator +(Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}
    }
}
