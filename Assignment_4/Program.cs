namespace Assignment_4;

internal class Program
{
    static void Main(string[] args)
    {
        #region Part01

        #region Question_1
        /*a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?*/

        //Answer -> DeliveryAddress is struct (value type),when it is copied, a new independent copy is created.
        //so it doesn`t modify original variable.


        /*b) What happens when a Customer variable is copied into another variable and one variable modifies the object? */

        //Answer ->Customer is class (reference type),when it is copied, only the reference is copied.
        //so it affects the original object and both variables refer to the same object.

        #endregion

        #endregion

    }
}
