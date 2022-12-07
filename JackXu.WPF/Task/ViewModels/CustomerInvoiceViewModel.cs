using JackXu.WPF.Task.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.WPF.Task.ViewModels
{
    public class CustomerInvoiceViewModel
    {
        public CustomerInvoiceViewModel()
        {
            CustomerInvoice= BuildInvoices();

        }

        public List<CustomerInvoice> CustomerInvoice { get; set; }

        private List<CustomerInvoice> BuildInvoices()
        {
            return new List<CustomerInvoice>()
            {
                new CustomerInvoice("INV-3066",Status.Paid,Customer(1,"Samuel","Jaja","Jaja@gmail.com"),61),
                new CustomerInvoice("INV-3065",Status.Paid,Customer(2,"Gideon","Sarah","Gideonsarah@gmail.com"),43),
                new CustomerInvoice("INV-3064",Status.Paid,Customer(3,"John","Paul","Johnpaul@gmail.com"),28),
                new CustomerInvoice("INV-3063",Status.Refunded,Customer(4,"Suzy","Obode","Suzy27@gmail.com"),85),
                new CustomerInvoice("INV-3061",Status.Paid,Customer(5,"Isaac","Aku","Isaac419@gmail.com"),60),
                new CustomerInvoice("INV-3060",Status.Cancelled,Customer(6,"Kelly","Osoba","Kellyosoba@gmail.com"),55),
                new CustomerInvoice("INV-3060",Status.Cancelled,Customer(7,"Faith","Lucky","Faith012@gmail.com"),35),
            };
        }

        private Customer Customer(int id, string fName,string lName, string emaile)
        {
            return new Customer(id,fName,lName,emaile);
        }
    }
}
