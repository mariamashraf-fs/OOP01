using Assignment_4.Structs;

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

        #region Question_2

        /* a) Identify at least three problems with this design from an encapsulation perspective.*/

        // Answer ->
        // 1-> All fields are public, so anyone can access and modify them.
        // 2-> There is no validation for the data.
        // 3-> There is no separation between data and logic.

        /*b) How can private fields and public properties improve this design?*/

        // Answer ->
        // 1-> Make the fields private to protect the data.
        // 2-> Use public properties to control access.
        // 3-> Add validation to accept only valid values.

        #endregion

        #endregion

        #region Part02

        #region Question_1
        /*Create one DeliveryAddress value, copy it into a second variable,
         modify the copy, and print both values to prove that the original did not change.*/

        //DeliveryAddress address1 = new DeliveryAddress("Beni-Suef", "Al-Wasta", 15);

        //DeliveryAddress address2 = address1;

        //address2.City = "Port-Said";

        //Console.WriteLine($"Original -> {address1.GetFullAddress()}");
        //Console.WriteLine($"Copy -> {address2.GetFullAddress()}");

        #endregion

        #region Question_2
        //DeliveryAddress address = new DeliveryAddress("Beni-Suef", "Al-Wasta", 15);

        //Shipment shipment = new Shipment("TR001", "Laptop", 3.5, 100, address);

        //shipment.PrintShipment();
        // Console.WriteLine("============================");

        //Console.WriteLine("After Updating Delivery Fee ->");
        //shipment.UpdateDeliveryFee(-50);
        //shipment.PrintShipment();



        #endregion

        #endregion

        #region Assignment_5

        #region Part01

        #region Question_1
        /*a) What is the difference between a class and a struct?*/

        //Answer ->
        // 1-> Class is reference type, struct is value type.
        // 2-> Class is stored on the Heap, struct is stored on the stack.
        // 3-> Class supports inheritance, struct does not.
        // 4-> Class can be null, struct cannot be null (unless declared as nullable).

        /*b) Why are classes more suitable than structs for large applications?*/

        //Answer -> 
        // 1-> Classes support inheritance, which helps organize and reuse code in large projects.
        // 2-> Classes are reference types, so multiple parts of the program can share and update the same object.

        #endregion

        #endregion

        #endregion

    }
}
