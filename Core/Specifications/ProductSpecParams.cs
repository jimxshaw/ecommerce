namespace Core.Specifications
{
  public class ProductSpecParams
  {
    private const int MaxPageSize = 50;

    // Set the default page size. Users are
    // free to choose any size 1 <= n <= 50.
    private int _pageSize = 6;

    private string _search;

    public int PageSize
    {
      get => _pageSize;
      set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }

    // Always return the first page.
    public int PageIndex { get; set; } = 1;

    public int? BrandId { get; set; }

    public int? TypeId { get; set; }

    public string Sort { get; set; }

    // Force user searches to be lowercase.
    public string Search
    {
      get => _search;
      set => _search = value.ToLower();
    }

  }
}