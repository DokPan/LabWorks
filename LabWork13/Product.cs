class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime ExpirationDate { get; set; }

    public override string ToString()
    {
        return $"{char.ToUpper(Name[0])}{Name.Substring(startIndex: 1).ToLower()};{Price:F2};{ExpirationDate:yyyy-MM-dd}";
    }
}
