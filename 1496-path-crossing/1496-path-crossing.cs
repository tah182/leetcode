public class Solution {
    public bool IsPathCrossing(string path) {
        var pointsPassed = new HashSet<(int x, int y)>();
        var position = (0, 0);
        
        pointsPassed.Add(position);
        
        foreach (var direction in path) {
            position = move(position, direction);
            if (pointsPassed.Contains(position))
                return true;
            
            pointsPassed.Add(position);
        }
        return false;
    }

    private static (int x, int y) move((int x, int y) position, char direction) {
        switch (direction) {
            case 'N':
                position.x++;
                break;
            case 'S':
                position.x--;
                break;
            case 'E':
                position.y++;
                break;
            case 'W':
                position.y--;
                break;
            default:
                throw new NotImplementedException();
        }
        return position;
    }
}