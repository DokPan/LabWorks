using System.Security.Cryptography;

string directoryPath = "Y:\\МДК.01.01";

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("None");
    return;
}

string[] files = Directory.GetFiles(directoryPath);

if (files.Length == 0)
{
    Console.WriteLine("None");
    return;
}

Console.WriteLine($"Хэширование файлов начато.");
Task<string>[] hashTasks = Array.ConvertAll(files, ComputeFileHashAsync);
string[] hashes = await Task.WhenAll(hashTasks);

Console.WriteLine("\nРезультаты: ");
foreach (string hash in hashes)
    Console.WriteLine(hash);

static string CalculateHash(byte[] data)
{
    using var sha256 = SHA256.Create();
    return Convert.ToHexString(sha256.ComputeHash(data));
}

static async Task<string> ComputeFileHashAsync(string fileName)
{
    byte[] data = await File.ReadAllBytesAsync(fileName);
    string hash = await Task.Run(() => CalculateHash(data));
    return $"{fileName} : {hash}";
}
