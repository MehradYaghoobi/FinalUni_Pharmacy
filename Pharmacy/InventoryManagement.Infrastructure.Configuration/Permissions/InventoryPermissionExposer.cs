using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "انبار", new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermissions.ListInventory, "لیست انبار"),
                        new PermissionDto(InventoryPermissions.SearchInventory, "جستجودرانبار"),
                        new PermissionDto(InventoryPermissions.CreateInventory, "ساخت انبار"),
                        new PermissionDto(InventoryPermissions.EditInventory, "ویرایش انبار"),
                        new PermissionDto(InventoryPermissions.Increase, "افزایش موجودی"),
                        new PermissionDto(InventoryPermissions.Reduce, "کاهش موجودی"),
                        new PermissionDto(InventoryPermissions.OperationLog, "گردش انبار")
                    }
                }
            };
        }
    }
}
