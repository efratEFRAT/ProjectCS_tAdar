namespace DAL
{
    public class SavingImages
    {
        private int id;
        private string orderCode;
        private Byte[] images;
        private int processStatus;
        private string size;
        public int Id { 
           get { return id; } 
           set {  id = value; } 
        }
        public string OrderCode
        {
            get { return orderCode; }
            set { orderCode = value; }
        }
        public Byte[] Images
        {
            get { return images; }
            set { images = value; }
        }
        public int ProcessStatus
        {
            get { return processStatus; }
            set { processStatus = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public SavingImages(string orderCode, Byte[] images,int processStatus,string size)
        {
            this.orderCode=orderCode;
            this.images=images;
            this.processStatus=processStatus;
            this.size=size;
           
        }
    }
}
