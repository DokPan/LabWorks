class StringComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        return string.Compare(x.Name, y.Name, StringComparison.Ordinal);  
    }
}
