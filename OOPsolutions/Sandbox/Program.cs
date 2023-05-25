// See https://aka.ms/new-console-template for more information

using OOPsReview;


Console.WriteLine("Hello, World!");

Residence myHome = new Residence(123, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());

//can i change a value in the record instance? NO
//myHome.Number = 321;

//to alter a value in the record instance, you must create a NEW instance
myHome = new Residence(321, "Maple St.", "Edmonton", "AB", "T6Y7U8");
Console.WriteLine(myHome.ToString());


//Refactoring is the process of restruvting code, while not changing the original functionality.
//The goal of refactoring is to improve internal code by making small changes without changing the external behaviour

//original code 

bool flag = false;
if (myHome.Province.ToLower() == "ab")
{
    flag = true;
}
if (myHome.Province.ToLower() == "bc")
{
    flag = true;

}
if (myHome.Province.ToLower() == "sk")
{
    flag = true;
}
if (myHome.Province.ToLower() == "mn")
{
    flag = true;
}

//refactor using a switch statement
switch (myHome.Province.ToLower())
{
    case "ab":
    case "bc":
    case "sk":
    case "mn":
        {
            flag = true;
            break;
        }
    default:
        {
            flag = false;
            break;
        }
}
Console.WriteLine(flag);