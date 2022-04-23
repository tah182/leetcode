public class Codec {
    Dictionary<string, string> map = new Dictionary<string, string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var textBytes = System.Text.Encoding.UTF8.GetBytes(longUrl);
        var result = System.Convert.ToBase64String(textBytes);
        map.Add(result, longUrl);
        // Console.WriteLine($"{result}");
        return $"http://tinyurl.com/{result}";
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string key = shortUrl.Replace("http://tinyurl.com/", "");
        string value;
        map.TryGetValue(key, out value);
        // Console.WriteLine($"{key}---{value}");
        return value;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));