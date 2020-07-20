namespace ShoppingCart.Interface
{
    public interface ITerminal
    {
        void Scan(string item);
        decimal Total();
    }
}
