﻿// See https://aka.ms/new-console-template for more information


using AccountValidation.Service_Credential_validation;

User user1 = new User();
user1.Email = "kamranss@gmail.com";
user1.Fullname = "Kamran S";
user1.Password = Console.ReadLine();

user1.ShowInfo();

