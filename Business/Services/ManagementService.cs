using Business.Interfaces;

namespace Business.Services
{
    public class ManagementService : IManagementService
    {
        private readonly IManagementRepository _managementRepository;

        public ManagementService(IManagementRepository managementRepository)
        {
            _managementRepository = managementRepository;
        }

        public Data.Data GetTable(int idData)
        {
            var data = new Data.Data
            {
                IdData = 1,
                Value = "test"
            };

            _managementRepository.AddData(data);


            return _managementRepository.GetTable(idData);
        }
    }
}
