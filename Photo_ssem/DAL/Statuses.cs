namespace DAL
{
    public class Statuses
    {
        private int id;
        private int processStatus;
        public string statusDescription;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int ProcessStatus
        {
            get { return processStatus; }
            set { processStatus = value; }
        }
        public string StatusDescription
        {
            get {return statusDescription;} 
            set { statusDescription = value; }
        }
        public Statuses(int id,int processStatus, string statusDescription) 
        {
            this.id = id;
            this.processStatus=processStatus;
            this.statusDescription = statusDescription;
            
        }

    }
}
