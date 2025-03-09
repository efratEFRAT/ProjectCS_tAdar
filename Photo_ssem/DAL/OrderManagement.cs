//using System.Xml.Linq;

//namespace DAL
//{
//    public class OrderManagement
//    {
//        private int id;
//        private string orderCode;
//        private int processStatus;
//        private string officerCode;
//        private string customersCode;

//        public int Id
//        {
//            get { return id; }
//            set { id = value; }

//        }
//        public string OrderCode
//        {
//            get { return orderCode; }
//            set { orderCode = value; }
//        }
//        public int ProcessStatus
//        {
//            get { return processStatus; }
//            set { processStatus = value; }
//        }
//        public string OfficerCode
//        {
//            get { return officerCode; }
//            set { officerCode = value; }
//        }
//        public string CustomersCode
//        {
//            get { return customersCode; }
//            set { customersCode = value; }
//        }
//        public OrderManagement(string orderCode, int processStatus, string officerCode, string customersCode)
//        {
//            this.orderCode = orderCode;
//            this.processStatus = processStatus;
//            this.officerCode = officerCode;
//            this.customersCode = customersCode;
//        }



//    }
//}


using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class OrderManagement
    {
        
        private int id;
        private string orderCode;
        private int processStatus;
        private string officerCode;
        private string customerCode; // Backing field for CustomersCode

        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string OrderCode
        {
            get { return orderCode; }
            set { orderCode = value; }
        }

        public int ProcessStatus
        {
            get { return processStatus; }
            set { processStatus = value; }
        }

        public string OfficerCode
        {
            get { return officerCode; }
            set { officerCode = value; }
        }

        public string CustomerCode // Ensure this matches the database
        {
            get { return customerCode; }
            set { customerCode = value; } // Change to backing field
        }

        public OrderManagement(string orderCode, int processStatus, string officerCode, string customerCode)
        {
            this.orderCode = orderCode;
            this.processStatus = processStatus;
            this.officerCode = officerCode;
            this.customerCode = customerCode; // Assigning constructor parameter to the backing field
        }

        // Parameterless constructor for EF (not shown but recommended)
    }
}
