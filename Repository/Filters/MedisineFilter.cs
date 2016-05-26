using System.Linq;
using Repository.Models;

namespace Repository.Filters
{
    public static class MedisineFilters
    {
        public static IQueryable<Medicine> WithId(this IQueryable<Medicine> q, int id)
        {
            return q.Where(medisine => medisine.Id == id);
        }

        public static IQueryable<Medicine> WithNameLike(this IQueryable<Medicine> q, string name)
        {
            return q.Where(medisine => medisine.Name.StartsWith(name));
        }

        public static IQueryable<Medicine> WithProductFormLike(this IQueryable<Medicine> q, string productForm)
        {
            return q.Where(medisine => medisine.ProductForm.StartsWith(productForm));
        }

        public static bool IsMedicineExist(this IQueryable<Medicine> q, string name,  string productForm, string manufacturer)
        {
            return q.Any(medisine => medisine.Name.StartsWith(name) && 
                medisine.ProductForm.StartsWith(productForm) && medisine.Manufacturer.StartsWith(manufacturer));
        }

    }
}
