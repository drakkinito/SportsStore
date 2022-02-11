using System.Linq;

namespace SportsStore.Models
{
    public interface IProductRepoitory
    {
        IQueryable<Product> Products { get; }
    }
}
