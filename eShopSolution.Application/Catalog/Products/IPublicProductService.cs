using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Commmon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCatagoryId(string languageId,GetPublicProductPagingRequest request);
        //Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
