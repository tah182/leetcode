/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    private IList<int> iterator = new List<int>();

    private void createList(IList<NestedInteger> nestedList) {
        foreach (var nestedInt in nestedList) {
            if (nestedInt.IsInteger())
                iterator.Add(nestedInt.GetInteger());

            createList(nestedInt.GetList());
        }
    }

    public NestedIterator(IList<NestedInteger> nestedList) {
        createList(nestedList);
    }

    public bool HasNext() {
        return iterator.Count > 0;
    }

    public int Next() {
        var next = iterator.First();
        iterator.RemoveAt(0);

        return next;
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */