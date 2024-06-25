using Shop.Repository;

namespace Shop.Extension
{
    public static class ShopExtension
    {
        public static IServiceCollection AddShopServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductsRepository, ProductsRepository>();
            serviceCollection.AddDbContext<ShopDbContext, ShopDbContext>();
            return serviceCollection;
        }
    }
}
