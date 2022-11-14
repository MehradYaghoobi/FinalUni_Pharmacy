using _01_PharmacyQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        //private readonly IProductQuery _productQuery;
        //private readonly ICommentApplication _commentApplication;

        //public ProductModel(IProductQuery productQuery, ICommentApplication commentApplication)
        //{
        //    _productQuery = productQuery;
        //    _commentApplication = commentApplication;
        //}

        private readonly IProductQuery _productQuery;

        public ProductModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public void OnGet(string id)
        {
            Product = _productQuery.GetProductDetails(id);
        }

        public IActionResult OnPost(/*AddComment command,*/ string productSlug)
        {
            //command.Type = CommentType.Product;
            //var result = _commentApplication.Add(command);
            return RedirectToPage("/Product", new { Id = productSlug });
        }
    }
}
