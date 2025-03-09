//namespace DAL
//{
//    public class Customers
//    {
//        private int id;
//        private string name;
//        private string customersCode;
//        private int phone;
//        public int Id
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public string CustomersCode
//        {
//            get { return customersCode; }
//            set { customersCode = value; }
//        }
//        public int Phone
//        {
//            get { return phone; }
//            set { phone = value; }
//        }
//        public Customers(string customersCode, string name, int phone)
//        {

//            this.name = name;
//            this.customersCode = customersCode;
//            this.phone = phone;

//        }
//    }
//}
namespace DAL
{
    public class Customers
    {
        private int id;
        private string name;
        private string customerCode; // Rename this to match the database column
        private int phone;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CustomerCode // Update property name to match the column
        {
            get { return customerCode; }
            set { customerCode = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Parameterless constructor for Entity Framework
        public Customers() { }

        public Customers(string customerCode, string name, int phone)
        {
            this.customerCode = customerCode; // Match property name
            this.Name = name;
            this.Phone = phone;
        }
    }
}