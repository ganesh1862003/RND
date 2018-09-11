using DI.Interfaces;
namespace DI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Delete(int ? id)
        {
            id = id + 1;
        }
    }
}
