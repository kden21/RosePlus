using RosePlus.AppServices.Mappers.Product;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services.Product;

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
        ProductEntity productEntity = await _productRepository.GetProductById(productId, cancellationToken);
        ProductDto productDto = new ProductDto();
        productDto.FillProductDto(productEntity);
        return productDto;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<ProductDto>> GetProductsAsync(ProductFilter productFilter, CancellationToken cancellationToken)
    {
        var productEntities = await _productRepository.GetProducts(productFilter, cancellationToken);
        List<ProductDto> productDtos = new List<ProductDto>();
        foreach (ProductEntity productEntity in productEntities)
        {
            ProductDto productDto = new ProductDto();
            productDto.FillProductDto(productEntity);
            productDtos.Add(productDto);
        }

        return productDtos;
    }

    /// <inheritdoc />
    public async Task<int> AddProductAsync(ProductDto productDto, CancellationToken cancellationToken)
    {
        ProductEntity productEntity = new ProductEntity(); 
        productEntity.FillProductEntity(productDto);
        return await _productRepository.AddProduct(productEntity, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteProductAsync(int productId, CancellationToken cancellationToken)
    {
        await _productRepository.DeleteProduct(productId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateProductAsync(ProductDto productDto, CancellationToken cancellationToken)
    {
        ProductEntity productEntity = await _productRepository.GetProductById(productDto.Id, cancellationToken);
        productEntity.FillProductEntity(productDto);
        await _productRepository.UpdateProduct(productEntity, cancellationToken);
    }
}