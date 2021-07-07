using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Commmon;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCatagoryId(GetPublicProductPagingRequest request);
    }
}
