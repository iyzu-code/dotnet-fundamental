namespace VendingMachine;

public class VendingMachine
{
    private Dictionary<string, Item> _inventory = new Dictionary<string, Item>();
    private decimal _currentBalance;

    public decimal CurrentBalance { get => _currentBalance; }

    public VendingMachine()
    {
        _inventory = new Dictionary<string, Item>();
        InitializeInventory();
    }

    private void InitializeInventory()
    {
        _inventory.Add("A1", new Drink("Cola", 1.50m, 5));
        _inventory.Add("A2", new Drink("Water", 1.00m, 8));
        _inventory.Add("B1", new Chip("Chip", 1.25m, 3));
        _inventory.Add("B2", new Chip("Pretzels", 1.25m, 4));
        _inventory.Add("C1", new Candy("Candy Bar", 0.75m, 0));
        _inventory.Add("C2", new Candy("Gum", 0.5m, 10));
    }

    public Dictionary<string, Item> GetInventory()
    {
        return _inventory;
    }

    public void InsertMoney(decimal amount)
    {
        switch (amount)
        {
            case <= 0:
                throw new ArgumentException();
            default:
                _currentBalance += amount;
                break;
        }
    }

    public decimal Refund()
    {
        var temp_balance = _currentBalance;
        _currentBalance = 0;
        return temp_balance;
    }

    public decimal PurchaseItem(string selectionCode)
    {
        if (!_inventory.ContainsKey(selectionCode)) throw new KeyNotFoundException($"*** ERROR: Code {selectionCode} does not exist. ***");

        var item = _inventory[selectionCode];

        if (item.Quantity <= 0) throw new OutOfStockException($"*** ERROR: Sorry, {item.Name} is out of stock. ***");

        if (_currentBalance < item.Price) throw new InsufficientFundsException($"*** ERROR: Insufficient funds. You need {item.Price - _currentBalance} more. ***");

        _currentBalance -= item.Price;
        item.Quantity--;
        Console.WriteLine($"\n  [Dispensing]: {item.Name}");
        item.Dispense();
        return _currentBalance;
    }
}
