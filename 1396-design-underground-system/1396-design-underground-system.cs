public class UndergroundSystem {

    Dictionary<int, (string stationName, int checkin)> checkins;
    Dictionary<string, List<int>> times;
    public UndergroundSystem() {
        checkins = new Dictionary<int, (string stationName, int checkin)>();
        times = new Dictionary<string, List<int>>();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        checkins.Add(id, (stationName, t));
    }
    
    public void CheckOut(int id, string stationName, int t) {
        var checkin = checkins[id];
        if (times.ContainsKey(checkin.stationName + "+" + stationName))
            times[checkin.stationName + "+" + stationName].Add(t - checkin.checkin);
        else
            times.Add($"{checkin.stationName}+{stationName}", new List<int> { t - checkin.checkin });
        
        checkins.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        //Console.WriteLine($"{startStation}+{endStation}, {string.Join(",", times[startStation+"+"+endStation])}--{times[startStation+"+"+endStation].Average()}");
        return times[startStation+"+"+endStation].Average();
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */