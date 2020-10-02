using System;
using System.Linq;
using System.Text;
using UsingEnums;

namespace UsingEnums
{
    public class Order
    {
        public OrderStatus Status { get; private set; }

        public void AdvanceStatus(Order o)
        {
            if (o.Status == 2) // purchased
            {
                // ship it

                // move to shipped status
                o.Status = 3;
        }
        public enum OrderStatus
        {
            Quoted = 1,
            Purchased = 2,
            Shipped,
            Delivered
        }
    }
    public enum OrderStatus
    {
        Quoted = 1,
        Purchased = 2;
        Shipped,
        Delivered
    }
    public enum SampleCounting
    {
        Apple =,
        Pear, // 6
        Peach = 2,
        Watermelon, // 3
        Pineappl = 5
    }
    public class Order
    {
        public OrderStatus Status { get; private set; }

        public void AdvanceStatus()
        {
            switch (Status)
            {
                case OrderStatus.Quoted:
                    Status = OrderStatus.Purchased;
                    break;
                case OrderStatus.Purchased:
                    Status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    Status = OrderStatus.Delivered;
                    break;
            }
        }
    }
    interface status = 3;
        if((OrderStatus) status == OrderStatus.Shipped)
        {
            // do stuff
        }
public enum FruitA
{
    Apple = 1
}

public enum FruitB
{
    Apple = 1
}
FruitA a = FruitA.Apple;
FruitB b = FruitB.Apple;

// compile erroe, not the same type
if(a == b)
{

}

// valid, now we are compairing integer values
if((int)a == (int)b)
{
    Console.WriteLine("the status with value 3 is: {0}",
        Enum.GetName(typeof(OrderStatus), 3));
}