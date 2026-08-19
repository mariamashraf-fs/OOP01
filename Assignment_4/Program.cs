using Assignment_4.Classes;
using Assignment_4.Interfaces;
using Assignment_4.Structs;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        #region Question_2
        /*a) Which class is the parent class?*/

        //Answer -> Shipment is the parent class.


        /*b) Which class is the child class?*/

        //Answer -> ExpressShipment is the child class.


        /*c) What members are inherited by ExpressShipment?*/

        //Answer -> ExpressShipment inherits the TrackingCode property from Shipment.


        /*d) Why is inheritance better than duplicating the same code in multiple classes?*/

        //Answer ->
        // 1-> It avoids repeating the same code.
        // 2-> Shared logic is written once and reused by child classes.
        // 3-> Changes can be made in one place.

        #endregion

        #endregion

        #region Part02

        #region Point_06

        /*6. In Main, build a Console Application that does the following:
           a. Create a DeliveryCenter.
           b. Read data for three shipments from the user.
           c. Create each Shipment and add it to the DeliveryCenter.
           d. Print the three shipments using the integer indexer.
           e. Ask the user to enter a tracking code.
           f. Search for the shipment using the string indexer.
           g. Print the shipment if found; otherwise print: Shipment not found.
           Demonstrate the DeliveryAddress struct copy behavior.*/

        //DeliveryCenter center = new DeliveryCenter();

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine($"Enter Shipment {i + 1} Data");

        //    Console.Write("Tracking Code: ");
        //    string trackingCode = Console.ReadLine()!;

        //    Console.Write("Description: ");
        //    string description = Console.ReadLine()!;

        //    double weight;
        //    do
        //    { Console.Write("Weight: ");
        //    } while (!double.TryParse(Console.ReadLine()!, out weight));

        //    decimal deliveryFee;
        //    do
        //    { Console.Write("Delivery Fee: ");
        //    } while (!decimal.TryParse(Console.ReadLine()!, out deliveryFee));

        //    Console.Write("City: ");
        //    string city = Console.ReadLine()!;

        //    Console.Write("Street: ");
        //    string street = Console.ReadLine()!;

        //    int buildingNumber;
        //    do
        //    { Console.Write("Building Number: ");
        //    } while (!int.TryParse(Console.ReadLine()!, out buildingNumber));

        //   DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);

        //   Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, address);

        //    if (center.AddShipment(shipment))
        //        Console.WriteLine("Shipment added successfully.");
        //    else
        //        Console.WriteLine("Delivery Center is full.");

        //    Console.WriteLine();
        //}

        //Console.WriteLine("--- All Shipments ---");

        //for (int i = 0; i < 3; i++)
        //{
        //    center[i].PrintShipment();
        //    Console.WriteLine();
        //}

        //Console.Write("Enter a tracking code to search: ");
        //string searchCode = Console.ReadLine()!;

        //Shipment searchedShipment = center[searchCode];

        //if (string.IsNullOrWhiteSpace(searchedShipment.TrackingCode))
        //    Console.WriteLine("Shipment not found.");
        //else
        //    Console.WriteLine($"Shipment found: {searchedShipment.TrackingCode} - {searchedShipment.Description}");

        //Console.WriteLine("--- Struct Copy Test ---");

        //DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 15);
        //DeliveryAddress address2 = address1;

        //address2.City = "Cairo";
        //address2.Street = "Makram Ebeid Street";
        //address2.BuildingNumber = 20;

        //Console.WriteLine($"Original Address: {address1.GetFullAddress()}");
        //Console.WriteLine($"Copied Address: {address2.GetFullAddress()}");

        #endregion

        #region Point_04

        /*4. Demonstrate Class Relationships

        Inheritance:
        Shipment
        ├── StandardShipment
        ├── ExpressShipment
        └── InternationalShipment */

        //The inheritance relationship is demonstrated by creating three child classes
        //(StandardShipment, ExpressShipment, and InternationalShipment) that inherit from the parent class Shipment.
        //This allows all shipment types to be treated as Shipment objects while keeping their specific behaviors.

        #endregion

        #region Point_05

        /*5. In Main
        Build a Console Application that performs the following:
        1. Create a DeliveryCenter.
        2. Read the center name from the user.
        3. Create one StandardShipment.
        4. Create one ExpressShipment.
        5. Create one InternationalShipment.
        6. Read all shipment data from the user.
        7. Add the shipments to the delivery center.
        8. Print all shipments.
        9. Search for a shipment using the existing tracking code indexer.
        10. Remove one shipment using its tracking code.
        11. Print the remaining shipments.*/


        //Console.Write("Enter Delivery Center Name: ");
        //string centerName = Console.ReadLine()!;

        //DeliveryCenter center = new DeliveryCenter(centerName);


        //// Standard Shipment 

        //Console.WriteLine("\n--- Enter Standard Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string stCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string stDesc = Console.ReadLine()!;

        //decimal stWeight;
        //do
        //{ Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stWeight));

        //decimal stFee;
        //do
        //{ Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stFee));

        //Console.Write("City: ");
        //string stCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string stStreet = Console.ReadLine()!;

        //int stBuilding;
        //do
        //{ Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out stBuilding));

        //DeliveryAddress standardAddress = new DeliveryAddress(stCity, stStreet, stBuilding);

        //StandardShipment standard = new StandardShipment( stCode, stDesc, stWeight, stFee, standardAddress);


        //// Express Shipment 

        //Console.WriteLine("\n--- Enter Express Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string exCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string exDesc = Console.ReadLine()!;

        //decimal exWeight;
        //do
        //{ Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exWeight));

        //decimal exFee;
        //do
        //{ Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exFee));

        //decimal extraFee;
        //do
        //{ Console.Write("Extra Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out extraFee));

        //Console.Write("City: ");
        //string exCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string exStreet = Console.ReadLine()!;

        //int exBuilding;
        //do
        //{ Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out exBuilding));

        //DeliveryAddress expressAddress = new DeliveryAddress(exCity, exStreet, exBuilding);

        //ExpressShipment express = new ExpressShipment( exCode, exDesc, exWeight, exFee, expressAddress, extraFee);


        ////International Shipment

        //Console.WriteLine("\n--- Enter International Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string inCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string inDesc = Console.ReadLine()!;

        //decimal inWeight;
        //do
        //{ Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inWeight));

        //decimal inFee;
        //do
        //{ Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inFee));

        //Console.Write("Destination Country: ");
        //string country = Console.ReadLine()!;

        //decimal customsFee;
        //do
        //{ Console.Write("Customs Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out customsFee));

        //Console.Write("City: ");
        //string inCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string inStreet = Console.ReadLine()!;

        //int inBuilding;
        //do
        //{ Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out inBuilding));

        //DeliveryAddress internationalAddress = new DeliveryAddress(inCity, inStreet, inBuilding);

        //InternationalShipment international = new InternationalShipment( inCode, inDesc, inWeight, inFee, internationalAddress, country,
        //                                          customsFee);



        //Console.WriteLine();
        //if (center.AddShipment(standard)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(express)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(international)) Console.WriteLine("Shipment Added Successfully.");
        //Console.WriteLine();

        //center.PrintAllShipments();


        ////Search 

        //Console.Write("\nEnter Tracking Code To Search: ");
        //string searchCode = Console.ReadLine()!;

        //Shipment? foundShipment = center[searchCode];

        //if (foundShipment != null)
        //{
        //    Console.WriteLine("\nShipment Found:");
        //    foundShipment.PrintShipment();
        //}
        //else
        //{
        //    Console.WriteLine("Shipment not found.");
        //}


        //// Remove 

        //Console.Write("\nEnter Tracking Code To Remove: ");
        //string removeCode = Console.ReadLine()!;

        //bool removed = center.RemoveShipment(removeCode);

        //if (removed)
        //{
        //    Console.WriteLine("Shipment Removed Successfully.\n");
        //}
        //else
        //{
        //    Console.WriteLine("Shipment not found.");
        //}


        //// Remaining 
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("Remaining Shipments");
        //Console.WriteLine("========================================");

        //center.PrintAllShipments();

        #endregion
        #endregion

        #endregion

        #region Assignment_6

        #region Part01

        #region Question_1

        /*a) What is the difference between Method Overloading and Method Overriding?*/

        //Answer ->
        // Method Overloading:
        // 1-> Same method name in the same class.
        // 2-> Different parameters.
        // 3-> It is Compile-Time Polymorphism.

        // Method Overriding:
        // 1-> A child class provides  new implementation for method from the parent class.
        // 2-> The method must be virtual in the parent class and override in the child class.
        // 3-> It is Runtime Polymorphism.


        /*b) What is the difference between Static Binding and Dynamic Binding?*/
        //Answer->
        // Static Binding:
        // 1-> The method call is decided at compile time.
        // 2-> It is mainly used with method overloading.

        // Dynamic Binding:
        // 1-> The method call is decided at runtime.
        // 2-> It is used with method overriding and virtual methods.


        #endregion

        #region Question_2

        /*a) What is the purpose of the sealed keyword when applied to a class?*/

        //Answer ->
        // 1-> It prevents the class from being inherited.
        // 2-> No other class can inherit from sealed class.


        /*b) What is the difference between a sealed class and a sealed method?*/

        //Answer ->
        // Sealed Class:
        // 1-> Prevents inheritance from the class.
        // 2-> No class can inherit from it.

        // Sealed Method:
        // 1-> Prevents further overriding of the method.
        // 2-> The class itself can still be inherited.


        /*c) Can a sealed method be overridden? Why?*/

        //Answer ->
        // No, the sealed method cannot be overridden because the sealed keyword prevents further overriding of that method in derived classes.

        #endregion

        #endregion

        #region Part02
        /*9  Main() Checklist
           ☐  a. Create a Driver.
           ☐  b. Create a DeliveryCenter.
           ☐  c. Assign the Driver to the DeliveryCenter.
           ☐  d. Create one StandardShipment.
           ☐  e. Create one ExpressShipment.
           ☐  f. Create one InternationalShipment.
           ☐  g. Add all shipments to the DeliveryCenter.
           ☐  h. Print all shipments using PrintAllShipments().
           ☐  i. Call DeliveryHelper.PrintShipmentDetails() for each shipment.
           ☐  j. Demonstrate both versions of UpdateWeight().
           ☐  k. Build a Shipment[] holding mixed types and print all of them in a loop.
           ☐  l. Demonstrate the sealed class and sealed method (comments or code).*/

        //// a. Create a Driver
        //Console.Write("Enter Driver Name: ");
        //string driverName = Console.ReadLine()!;

        //Driver driver = new Driver(driverName);


        //// b. Create a DeliveryCenter
        //Console.Write("Enter Delivery Center Name: ");
        //string centerName = Console.ReadLine()!;

        //DeliveryCenter center = new DeliveryCenter(centerName);


        //// c. Assign the Driver to the DeliveryCenter
        //center.AssignedDriver = driver;

        //// d. Create one StandardShipment
        //Console.WriteLine("\n--- Enter Standard Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string stCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string stDesc = Console.ReadLine()!;

        //decimal stWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stWeight));

        //decimal stFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stFee));

        //Console.Write("City: ");
        //string stCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string stStreet = Console.ReadLine()!;

        //int stBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out stBuilding));

        //DeliveryAddress standardAddress = new DeliveryAddress(stCity, stStreet, stBuilding);
        //StandardShipment standard = new StandardShipment(stCode, stDesc, stWeight, stFee, standardAddress);


        //// e. Create one ExpressShipment
        //Console.WriteLine("\n--- Enter Express Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string exCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string exDesc = Console.ReadLine()!;

        //decimal exWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exWeight));

        //decimal exFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exFee));

        //decimal extraFee;
        //do
        //{
        //    Console.Write("Extra Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out extraFee));

        //Console.Write("City: ");
        //string exCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string exStreet = Console.ReadLine()!;

        //int exBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out exBuilding));

        //DeliveryAddress expressAddress = new DeliveryAddress(exCity, exStreet, exBuilding);
        //ExpressShipment express = new ExpressShipment(exCode, exDesc, exWeight, exFee, expressAddress, extraFee);


        //// f. Create one InternationalShipment
        //Console.WriteLine("\n--- Enter International Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string inCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string inDesc = Console.ReadLine()!;

        //decimal inWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inWeight));

        //decimal inFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inFee));

        //Console.Write("Destination Country: ");
        //string country = Console.ReadLine()!;

        //decimal customsFee;
        //do
        //{
        //    Console.Write("Customs Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out customsFee));

        //Console.Write("City: ");
        //string inCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string inStreet = Console.ReadLine()!;

        //int inBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out inBuilding));

        //DeliveryAddress internationalAddress = new DeliveryAddress(inCity, inStreet, inBuilding);
        //InternationalShipment international = new InternationalShipment(inCode, inDesc, inWeight, inFee, internationalAddress, country, customsFee);

        //// g. Add all shipments to the DeliveryCenter
        //Console.WriteLine();
        //if (center.AddShipment(standard)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(express)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(international)) Console.WriteLine("Shipment Added Successfully.");


        //// h. Print all shipments using PrintAllShipments()
        //center.PrintAllShipments();


        //// i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("Printing Using DeliveryHelper...\n");

        //DeliveryHelper.PrintShipmentDetails(standard);
        //DeliveryHelper.PrintShipmentDetails(express);
        //DeliveryHelper.PrintShipmentDetails(international);

        //// j. Demonstrate both versions of UpdateWeight()
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("Updating Weight...\n");

        //Console.WriteLine($"Original Weight : {standard.Weight} KG");

        //decimal newWeight;
        //do
        //{
        //    Console.Write("Enter New Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out newWeight));

        //standard.UpdateWeight(newWeight);
        //Console.WriteLine($"Updated Weight : {standard.Weight} KG");

        //decimal packingWeight;
        //do
        //{
        //    Console.Write("Enter Packing Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out packingWeight));

        //standard.UpdateWeight(newWeight, packingWeight);
        //Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

        //// k. Build a Shipment[] holding mixed types and print all of them in a loop
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("Printing Using Shipment[]...\n");

        //Shipment[] mixedShipments = { standard, express, international };

        //foreach (Shipment s in mixedShipments)
        //{
        //    s.PrintShipment();
        //    Console.WriteLine();
        //}

        //// l. Demonstrate the sealed class and sealed method

        ////Answer ->  CompletedShipment is sealed class,so it cannot be inherited by another class.

        //// GenerateCustomsReport() is sealed in PriorityInternationalShipment,so it cannot be overridden again in derived class.

        //Console.WriteLine("\n========================================");

        #endregion

        #endregion

        #region Assignment_7

        #region Part01

        #region Question_1
        /*a) What is Abstraction in Object-Oriented Programming?*/

        //Answer -> 
        // Abstraction is the process of hiding unnecessary implementation details
        // and showing only the essential features and behavior of an object.


        /*b) Why is abstraction considered one of the four pillars of OOP?*/

        //Answer ->
        //Because it helps simplify complex systems by hiding implementation details and exposing only what  is necessary and
        //it makes the code easier to understand, maintain, and use.

        #endregion

        #region Question_2
        /*a) What is the difference between an Abstract Class and an Interface?*/

        // Answer ->
        // Abstract Class:
        // 1 -> It can contain both abstract and non-abstract methods and properties.
        // 2 -> It can contain fields and constructors.
        // 3 ->Class can inherit from only one abstract class.
        // 4 -> It is used when related classes share common state and behavior.

        // Interface:
        // 1 -> It defines contract that implementing classes must follow.
        // 2 -> It does not represent shared object state like abstract class.
        // 3 -> A class can implement multiple interfaces.
        // 4 -> It is used when different classes need to provide the same behavior or capability.


        /*b) When would you choose an Interface instead of an Abstract Class?*/

        // Answer ->
        // I would choose Interface when different or unrelated classes need to follow the same contract
        // or provide the same capability, especially when class may need to implement more than one behavior.

        /*c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?*/

        // Answer ->
        // No, a class cannot inherit from multiple abstract classes because
        // C# supports single class inheritance.

        // Yes, a class can implement multiple interfaces because C# supports
        // multiple interface implementation.

        #endregion

        #endregion

        #region Part02
        /*8 Main() Checklist
        ☐ a. Create one StandardShipment.
        ☐ b. Create one ExpressShipment.
        ☐ c. Create one InternationalShipment.
        ☐ d. Add all shipments to the DeliveryCenter.
        ☐ e. Print all shipment details.
        ☐ f. Print the tracking status of every shipment.
        ☐ g. Print the insurance cost of every shipment.
        ☐ h. Store the shipment objects in an ITrackable[] array and print their tracking statuses.
        ☐ i. Store the shipment objects in an IInsurable[] array and print their insurance values.*/

        //Console.Write("Enter Delivery Center Name: ");
        //string centerName = Console.ReadLine()!;

        //DeliveryCenter center = new DeliveryCenter(centerName);


        //// a. Create one StandardShipment
        //Console.WriteLine("\n--- Enter Standard Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string stCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string stDesc = Console.ReadLine()!;

        //decimal stWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stWeight));

        //decimal stFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out stFee));

        //Console.Write("City: ");
        //string stCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string stStreet = Console.ReadLine()!;

        //int stBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out stBuilding));

        //DeliveryAddress standardAddress = new DeliveryAddress(stCity, stStreet, stBuilding);
        //StandardShipment standard = new StandardShipment(stCode, stDesc, stWeight, stFee, standardAddress);


        //// b. Create one ExpressShipment
        //Console.WriteLine("\n--- Enter Express Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string exCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string exDesc = Console.ReadLine()!;

        //decimal exWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exWeight));

        //decimal exFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out exFee));

        //decimal extraFee;
        //do
        //{
        //    Console.Write("Extra Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out extraFee));

        //Console.Write("City: ");
        //string exCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string exStreet = Console.ReadLine()!;

        //int exBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out exBuilding));

        //DeliveryAddress expressAddress = new DeliveryAddress(exCity, exStreet, exBuilding);
        //ExpressShipment express = new ExpressShipment(exCode, exDesc, exWeight, exFee, expressAddress, extraFee);


        //// c. Create one InternationalShipment
        //Console.WriteLine("\n--- Enter International Shipment Data ---");

        //Console.Write("Tracking Code: ");
        //string inCode = Console.ReadLine()!;

        //Console.Write("Description: ");
        //string inDesc = Console.ReadLine()!;

        //decimal inWeight;
        //do
        //{
        //    Console.Write("Weight: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inWeight));

        //decimal inFee;
        //do
        //{
        //    Console.Write("Delivery Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out inFee));

        //Console.Write("Destination Country: ");
        //string country = Console.ReadLine()!;

        //decimal customsFee;
        //do
        //{
        //    Console.Write("Customs Fee: ");
        //}
        //while (!decimal.TryParse(Console.ReadLine(), out customsFee));

        //Console.Write("City: ");
        //string inCity = Console.ReadLine()!;

        //Console.Write("Street: ");
        //string inStreet = Console.ReadLine()!;

        //int inBuilding;
        //do
        //{
        //    Console.Write("Building Number: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out inBuilding));

        //DeliveryAddress internationalAddress = new DeliveryAddress(inCity, inStreet, inBuilding);
        //InternationalShipment international = new InternationalShipment(inCode, inDesc, inWeight, inFee, internationalAddress, country, customsFee);


        //// d. Add all shipments to the DeliveryCenter
        //Console.WriteLine();
        //if (center.AddShipment(standard)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(express)) Console.WriteLine("Shipment Added Successfully.");
        //if (center.AddShipment(international)) Console.WriteLine("Shipment Added Successfully.");


        //// e. Print all shipment details
        //center.PrintAllShipments();


        //// f. Print the tracking status of every shipment
        //center.PrintTrackingStatuses();


        //// g. Print the insurance cost of every shipment
        //DeliveryReport report = new DeliveryReport();
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("\nInsurance");

        //Console.Write("\nStandard Shipment ");
        //report.PrintInsurance(standard);
        //Console.Write("\nExpress Shipment ");
        //report.PrintInsurance(express);
        //Console.Write("\nInternational Shipment ");
        //report.PrintInsurance(international);

        ////h.Store the shipment objects in an ITrackable[] array and print their tracking statuses
        //ITrackable[] trackableShipments = { standard, express, international };
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("\nTracking Status Using ITrackable[]");

        //foreach (ITrackable t in trackableShipments)
        //{
        //    report.PrintShipment(t);
        //}


        ////i.Store the shipment objects in an IInsurable[] array and print their insurance values
        //IInsurable[] insurableShipments = { standard, express, international };
        //Console.WriteLine("\n========================================");
        //Console.WriteLine("\nInsurance Using IInsurable[]");

        //foreach (IInsurable ins in insurableShipments)
        //{
        //    report.PrintInsurance(ins);
        //}


        //Console.WriteLine("\n========================================");
        //Console.WriteLine("\nInterface Polymorphism Demonstrated Successfully.");






        #endregion

        #endregion

        #region Assignment_8            

        #region Part01

        #region Question_1

        /*a) What happens when you assign one object variable to another object variable?*/

        //Answer ->
        // Both variables refer to the same object in memory.
        // No new object is created.


        /*b) Does assigning one object to another create a new object? Explain.*/

        //Answer ->
        // No,Assigning one object variable to another does not create new object and it only copies the reference
        // to the same object.


        /*c) What is the difference between copying an object and copying its reference?*/

        //Answer ->
        // Copying the reference means both variables point to the same object.
        // Copying the object means creating a new object with the same data as the original.

        #endregion

        #region Question_2

        /*a) What is a Shallow Copy?*/

        //Answer ->
        // A Shallow Copy creates a new object and copies the values of the original object's fields and
        // reference-type fields still refer to the same objects.


        /*b) What is a Deep Copy?*/

        //Answer ->
        // A Deep Copy creates a new object and also creates new copies of its reference-type members, so the copied object
        // is completely independent from the original.


        /*c) What happens to reference-type members when a Shallow Copy is created?*/

        //Answer ->
        // The references are copied, not the objects themselves and therefore, both the original
        // and copied objects refer to the same reference-type object.


        /*d) What happens to reference-type members when a Deep Copy is created?*/

        //Answer ->
        // New objects are created for the reference-type members,so the original and copied objects have
        // independent references.


        /*e) Give one situation where Deep Copy would be safer than Shallow Copy.*/

        //Answer ->
        // Deep Copy is safer when changing the copied object must not affect the original object,especially when
        // the object contains reference-type members such as DeliveryAddress.

        #endregion

        #region Question_3

        /*a) What is a static field, and how is it different from an instance field?*/

        //Answer ->
        // A static field belongs to the class itself and is shared by all objects of that class.
        // An instance field belongs to each individual object, so every object has its own copy.


        /*b) What is a static method? Can a static method directly access instance members?*/

        //Answer ->
        // A static method belongs to the class and can be called without creating an object.
        // No, Because instance members belong to a specific object.


        /*c) What is a static constructor, and when is it executed?*/

        //Answer ->
        // A static constructor is used to initialize static members.
        // It is executed automatically once, before the first instance of the class is created or before any
        // static member is accessed.


        /*d) What is a static class? Can you create an object from a static class?*/

        //Answer ->
        // A static class contains only static members and cannot be instantiated.
        // No, you cannot create an object from a static class.

        #endregion

        #region Question_4

        /*a) What is an Extension Method?*/

        //Answer ->
        // An Extension Method allows you to add a new method to an existing type without modifying its original class
        // or creating a derived class.


        /*b) What keyword must be used in the first parameter of an extension method?*/

        //Answer -> this


        /*c) Where must an extension method be declared?*/

        //Answer -> It must be declared inside a static class.


        /*d) Can an extension method access private members of the class it extends?*/

        //Answer ->
        // No, An extension method cannot directly access private members of the class it extends.

        #endregion

        #endregion

        #endregion



    }
}
