using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.WPF.Task.Models
{
    public class Customer
    {
        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
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
    }

    public enum Status
    {
        Paid, Refunded,Cancelled
    }
}
