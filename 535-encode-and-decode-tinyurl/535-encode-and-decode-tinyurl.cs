public class Codec {
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        string result = Convert.ToBase64String(Encoding.UTF8.GetBytes(longUrl));
        return $"http://tinyurl.com/{result}";
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string key = shortUrl.Replace("http://tinyurl.com/", "");
        string result = Encoding.UTF8.GetString(Convert.FromBase64String(key));
        return result;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));