using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "محصولات", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "لیست محصولات"),
                        new PermissionDto(ShopPermissions.SearchProducts, "جستجودرمحصولات"),
                        new PermissionDto(ShopPermissions.CreateProduct, "ایجادمحصول"),
                        new PermissionDto(ShopPermissions.EditProduct, "ویرایش محصول"),
                    }
                },
                {
                    "دسته بندی محصولات", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductCategories, "جستجودردسته محصولات"),
                        new PermissionDto(ShopPermissions.ListProductCategories, "لیست محصولات"),
                        new PermissionDto(ShopPermissions.CreateProductCategory, "ایجاددسته محصول"),
                        new PermissionDto(ShopPermissions.EditProductCategory, "ویرایش دسته محصول"),
                    }
                }
            };
        }
    }
}
