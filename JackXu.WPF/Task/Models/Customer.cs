using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.WPF.Task.Models
{
    public class Customer
    {
        public Customer(int id, string fName,string lName, string email)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName =>$"{FirstName} {LastName}";
        public string Initial => $"{GetInitial(FirstName)}{GetInitial(LastName)}";
        public string Email { get; set; }

     


        private string GetInitial(string str)
        {
            return str.Substring(0, 1);
        }
    }
    public class CustomerInvoice
    {
        public CustomerInvoice(string invoice, Status status, Customer customer, double progress)
        {
            Invoice = invoice;
            Status = status;
            Customer = customer;
            Progress = progress;
        }
        public string Invoice { get; set; }
        public Status Status { get; set; }
        public Customer Customer { get; set; }
        public double Progress { get; set; }

        private List<Regions> _regions;

        public List<Regions> Regions
        {
            get { return _regions; }
            set { _regions = value; }
        }

    }

    public enum Status
    {
        Paid, Refunded,Cancelled
    }
}
