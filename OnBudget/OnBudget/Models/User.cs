namespace OnBudget.Models
{
    public class User : BaseDataObject
    {
        string userid = string.Empty;
        public string UserId
        {
            get { return userid; }
            set { SetProperty(ref userid, value); }
        }

        string firstname = string.Empty;
        public string Firstname
        {
            get { return firstname; }
            set { SetProperty(ref firstname, value); }
        }

        string lastname = string.Empty;
        public string Lastname
        {
            get { return lastname; }
            set { SetProperty(ref lastname, value); }
        }

        string emailAdress = string.Empty;
        public string Emailadress
        {
            get { return emailAdress; }
            set { SetProperty(ref emailAdress, value); }
        }
    }
}
