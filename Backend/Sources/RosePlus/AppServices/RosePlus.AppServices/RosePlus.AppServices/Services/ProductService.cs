using RosePlus.AppServices.Mappers.Product;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Requests;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductDto> GetProductByIdAsync(int productId, CancellationToken cancellationToken)
    {
        var productEntity = await _productRepository.GetProductById(productId, cancellationToken);
        return new ProductDto
        {
            Count = productEntity.Count,
            Id = productEntity.Id,
            Price = productEntity.Price
        };
    }

    public async Task<IEnumerable<ProductDto>> GetProductsAsync(ProductRequest productRequest, CancellationToken cancellationToken)
    {
        var productEntities = await _productRepository.GetProducts(productRequest, cancellationToken);
        List<ProductDto> productDtos = new List<ProductDto>();
        foreach (ProductEntity productEntity in productEntities)
        {
            productDtos.Add(productEntity.FillDto());
        }

        return productDtos;
    }

    public async Task<int> AddProductAsync(ProductDto productDto, CancellationToken cancellationToken)
    {
        return await _productRepository.AddProduct(productDto.FillEntity(), cancellationToken);
    }
}