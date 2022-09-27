using BercaCafe_API.ViewModels;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        int PlaceOrder(OrderTransactionVM orderTransaction);
        OrderTransactionVM ComposeOrder(EmployeeCardDataVM employee, OrderVM order);
    }
}
