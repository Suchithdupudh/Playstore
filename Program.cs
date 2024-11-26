using Playstore;

Console.WriteLine("My Play Store");
//  To create Object for class
User userObj = new User();
userObj.CreateUser();
Categories categories = new Categories(11,"Fashion","Fashion Test");
Console.WriteLine(categories.Id);  
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "abc");
categories.AddCategory(2, "abc","asdfghjk");
