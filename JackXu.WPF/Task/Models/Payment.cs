using JackXu.WPF.Task.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackXu.WPF.Task.Models
{
    public class Payment : IPayment
    {
        public string Name { get; }

        public Payment(string _bankName)
        {
           this.Name = _bankName;
        }
        private Payment() { }
        private static Payment instance = null;
        public static Payment Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Payment("GTBank");
                    
                }
                return instance;
            }
        }
    }
}
