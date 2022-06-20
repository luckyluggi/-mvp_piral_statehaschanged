public class ShoppingCartState
{
    public List<string> Items { get; private set; } = new();

    public event Action OnChange;

    public void AddItem(string item)
    {
        Items.Add(item);
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}