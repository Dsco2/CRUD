namespace Business.Interfaces
{
    public interface IManagementRepository
    {
        Data.Data GetTable(int idData);
        bool AddData(Data.Data data);
    }
}
