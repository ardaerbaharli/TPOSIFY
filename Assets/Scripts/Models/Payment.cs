namespace Models
{
    public class Payment
    {
        private string ccNumber;
        private string ccMonth;
        private string ccYear;
        private string ccCVV;

        public Payment(string ccNumber, string ccMonth, string ccYear, string ccCVV)
        {
            CCNumber = ccNumber;
            CCMonth = ccMonth;
            CCYear = ccYear;
            CCCVV = ccCVV;
        }
        public string CCNumber
        {
            get { return ccNumber; }
            set { ccNumber = value; }
        }

        public string CCMonth
        {
            get { return ccMonth; }
            set { ccMonth = value; }
        }

        public string CCYear
        {
            get { return ccYear; }
            set { ccYear = value; }
        }

        public string CCCVV
        {
            get { return ccCVV; }
            set { ccCVV = value; }
        }
    }
}