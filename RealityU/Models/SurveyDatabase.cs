using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace RealityU.Models
{
    public class SurveyDbContext : DbContext 
    {
        public DbSet<SurveyDatabase> Survey { get; set; }
        public DbSet<Student> Students { get; set; }
    }

    public class SurveyDatabase : DropCreateDatabaseIfModelChanges<SurveyDbContext>
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public string FamilyStatus { get; set; }
        [Required]
        public decimal AnnualSalary { get; set; }
        [Required]
        public decimal MonthlySalary { get; set; }
        [Required]
        public decimal AnnualTaxes { get; set; }
        [Required]
        public decimal MonthlyTaxes { get; set; }

        public decimal ChildSupport { get; set; }

        public decimal SpouseIncome { get; set; }

        public decimal NetMonthlyIncome { get; set; }

        public decimal CollgeLoans { get; set; }

        public int CreditScore { get; set; }

        [Required]
        public decimal CheckbookEntry { get; set; }
    }

    public class Student : DropCreateDatabaseIfModelChanges<SurveyDbContext>
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Group { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public decimal GPA { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public decimal Salary { get; set; }

        public string MarriedTo { get; set; }
        [Required]
        public int Kids { get; set; }
        [Required]
        public bool Married { get; set; }
        [Required]
        public string Home { get; set; }
        [Required]
        public string Vehicle { get; set; }
        [Required]
        public bool CreditCard { get; set; }

        public string CreditCardUse { get; set; }
        [Required]
        public string GroceriesType { get; set; }
        [Required]
        public decimal Savings { get; set; }
        [Required]
        public string Entertainment { get; set; }
    }
}