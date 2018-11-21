using System;

namespace AnimalClinicProject.Models
{
    public class ClientFacade : BaseInpc
    {
        public ClientFacade(Client client)
        {
            Client = client;
        }

        public Client Client { get; private set; }
        public string FirstName
        {
            get => Client.FirstName;
            set
            {
                Client.FirstName = value;
                OnPropertyChanged();
            }
        }
        public string MiddleName
        {
            get => Client.MiddleName;
            set
            {
                Client.MiddleName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => Client.LastName;
            set
            {
                Client.LastName = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthdate
        {
            get => Client.Birthdate;
            set
            {
                Client.Birthdate = value;
                OnPropertyChanged();
            }
        }
        public Gender Gender
        {
            get => Client.Gender;
            set
            {
                Client.Gender = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get => Client.Address;
            set
            {
                Client.Address = value;
                OnPropertyChanged();
            }
        }
        public string ContactNo
        {
            get => Client.ContactNo;
            set
            {
                Client.ContactNo = value;
                OnPropertyChanged();
            }
        }
        public string EmailAddress
        {
            get => Client.EmailAddress;
            set
            {
                Client.EmailAddress = value;
                OnPropertyChanged();
            }
        }
        public string FacebookLink
        {
            get => Client.FacebookLink;
            set
            {
                Client.FacebookLink = value;
                OnPropertyChanged();
            }
        }
    }
}
