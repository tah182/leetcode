public class MyCalendar {
    private List<(int start, int end)> bookings;
    public MyCalendar() {
        // Console.WriteLine("-----");
        bookings = new List<(int start, int end)>();
    }
    
    public bool Book(int start, int end) {
        if (!bookings.Any(b => (start >= b.start && start < b.end)
                            || (end > b.start && end <= b.end)
                            || (start <= b.start && end >= b.end)))
        {
            // Console.WriteLine($"added: [{start}, {end}]");
            bookings.Add(new (start, end));
            return true;
        } 
        // var match = bookings.First(b => (start >= b.start && start < b.end)
        //                     || (end > b.start && end <= b.end)
        //                     || (start <= b.start && end >= b.end));
        // Console.WriteLine($"double book: [{start}, {end}] against: [{match.start}, {match.end}]");
        return false;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */