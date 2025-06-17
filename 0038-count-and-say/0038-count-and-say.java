class Solution {
    public String countAndSay(int n) {
        return countAndSayInternal(1, n, "");
    }

    private String countAndSayInternal(int i, int n, String s) {
        // do the encoding
        String encoding = getEncoding(s);
        // System.out.println("encoding [" + encoding + "] iteration: " + i + "/" + n);

        if (i == n)
            return encoding;
        else
            return countAndSayInternal(i + 1, n, encoding);
    }

    private String getEncoding(String s) {
        if (s == null || s.isEmpty()) 
            return "1";

        StringBuilder encodedString = new StringBuilder();
        int n = s.length();
        int i = 0;

        while (i < n) {
            char currentChar = s.charAt(i);
            int count = 0;

            // Count consecutive occurrences of the current character
            int j = i;
            while (j < n && s.charAt(j) == currentChar) {
                count++;
                j++;
            }

            // Append count and character to the encoded string
            encodedString.append(count).append(currentChar);

            // Move the pointer to the next distinct character
            i = j;
        }

        return encodedString.toString();
    }
}