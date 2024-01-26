namespace RosePlus.Domain.Entities.Files;

/// <summary>
/// Сущность файла.
/// </summary>
public class FileEntity : BaseEntity
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Контент.
    /// </summary>
    public byte[] Content { get; set; }
    
    /// <summary>
    /// Расширение.
    /// </summary>
    public string Extension { get; set; }
    
    /// <summary>
    /// Путь.
    /// </summary>
    public string Path { get; set; }
    
    /// <summary>
    /// Прзнак сжатия.
    /// </summary>
    public bool IsCompressed { get; set; }
    
    /// <summary>
    /// Наличие водяного знака.
    /// </summary>
    public bool IsWatermark { get; set; }
    
    /// <summary>
    /// Порядковый номер.
    /// </summary>
    public int? OrderNumber { get; set; }
}