Console.WriteLine(GetSize(50000));

string GetSize(long bytes)
{
    if (bytes < 1 << 10)
        return $"{bytes} Б";
    if (bytes < 1 << 20)
        return $"{bytes >> 10} КБ";
    if (bytes < 1 << 30)
        return $"{bytes >> 20} МБ";
    return $"{bytes >> 30} ГБ";
}
