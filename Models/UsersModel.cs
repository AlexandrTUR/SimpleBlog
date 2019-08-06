using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class UsersModel
    {
        public string name;
        public string surname;
        public int age;
        public bool isHasCare = true;

        public UsersModel(string name, string surname, int age, bool isHasCare) {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.isHasCare = isHasCare;
        } 
    }
}