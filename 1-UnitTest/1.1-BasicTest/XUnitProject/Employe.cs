using System;
using System.Collections.Generic;

namespace XUnitProject
{
    public class Person
    {
        public string Name { get; protected set; }
        public string NickName { get; set; }
    }

    public class Employe : Person
    {
        public double Salary { get; private set; }
        public ProfessionalLevel ProfessionalLevel { get; private set; }
        public IList<string> Skills { get; private set; }

        public Employe(string name, double salary)
        {
            Name = string.IsNullOrEmpty(name) ? "Unknown" : name;
            SalaryDefine(salary);
            DefineSkills();
        }

        public void SalaryDefine(double salary)
        {
            if (salary < 500) throw new Exception("Salary less than allowed");

            Salary = salary;
            if (salary < 2000) ProfessionalLevel = ProfessionalLevel.Junior;
            else if (salary >= 2000 && salary < 8000) ProfessionalLevel = ProfessionalLevel.Pleno;
            else if (salary >= 8000) ProfessionalLevel = ProfessionalLevel.Senior;
        }

        private void DefineSkills()
        {
            var basicSkills = new List<string>()
            {

                "Programming logic",
                "OOP"
            };

            Skills = basicSkills;

            switch (ProfessionalLevel)
            {
                case ProfessionalLevel.Pleno:
                    Skills.Add("Tests");
                    break;
                case ProfessionalLevel.Senior:
                    Skills.Add("Tests");
                    Skills.Add("Microservices");
                    break;
            }
        }
    }

    public enum ProfessionalLevel
    {
        Junior,
        Pleno,
        Senior
    }

    public class EmployeFactory
    {
        public static Employe Create(string name, double salary)
        {
            return new Employe(name, salary);
        }
    }
}
