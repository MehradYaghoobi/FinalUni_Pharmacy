using _01_PharmacyQuery.Contracts.ProductCategory;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PharmacyQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        //private readonly ShopContext _context;
        //private readonly InventoryContext _inventoryContext;
        //private readonly DiscountContext _discountContext;

        //public ProductCategoryQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        //{
        //    _context = context;
        //    _discountContext = discountContext;
        //    _inventoryContext = inventoryContext;
        //}
        private readonly ShopContext _context;
        
        public ProductCategoryQuery(ShopContext context)
        {
            _context = context;
        }

        public List<ProductCategoryQueryModel> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new ProductCategoryQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).AsNoTracking().ToList();
        }

    }
}
