namespace DAL
{
    public class Officer
    {
        private int id;
        private string name;
        private string officerCode;
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
        public string OfficerCode
        {
            get { return officerCode; }
            set { officerCode = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Officer(int id,string name,string officerCode,int phone) 
        {
            this.id = id;
            this.name = name;
            this.officerCode = officerCode;
            this.phone = phone;
        
        }
    }
}