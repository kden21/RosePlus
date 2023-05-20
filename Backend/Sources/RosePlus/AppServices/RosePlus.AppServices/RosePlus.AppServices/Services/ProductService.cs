using RosePlus.AppServices.Mappers.Product;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Requests;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services;

/// <inheritdoc />
public class ProductService : IProductService
{
    /// <summary>
    /// Репозиторий для работы с товарами.
    /// </summary>
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    /// <inheritdoc />
    public async Task<ProductDto> GetProductByIdAsync(int productId, CancellationToken cancellationToken)
    {
        return (await _productRepository.GetProductById(productId, cancellationToken)).ProductMappDto();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<ProductDto>> GetProductsAsync(ProductRequest productRequest, CancellationToken cancellationToken)
    {
        var productEntities = await _productRepository.GetProducts(productRequest, cancellationToken);
        List<ProductDto> productDtos = new List<ProductDto>();
        foreach (ProductEntity productEntity in productEntities)
        {
            productDtos.Add(productEntity.ProductMappDto());
        }

        return productDtos;
    }

    /// <inheritdoc />
    public async Task<int> AddProductAsync(ProductDto productDto, CancellationToken cancellationToken)
    {
        return await _productRepository.AddProduct(productDto.MapProductEntity(), cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteProductAsync(int productId, CancellationToken cancellationToken)
    {
        await _productRepository.DeleteProduct(productId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateProductAsync(ProductDto productDto, CancellationToken cancellationToken)
    {
        await _productRepository.UpdateProduct(productDto.MapProductEntity(), cancellationToken);
    }
}