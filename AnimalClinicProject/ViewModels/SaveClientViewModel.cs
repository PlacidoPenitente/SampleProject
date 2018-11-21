using AnimalClinicProject.Models;

namespace AnimalClinicProject.ViewModels
{
    public class SaveClientViewModel : SaveViewModel
    {
        public SaveClientViewModel(Client client)
        {
            AppDbContext = new AppDbContext();
            ClientFacade = new ClientFacade(client ?? new Client());
        }

        public ClientFacade ClientFacade { get; set; }

        public override void Save()
        {
            AppDbContext.Clients.Add(ClientFacade.Client);
            AppDbContext.SaveChanges();
        }
    }
}
