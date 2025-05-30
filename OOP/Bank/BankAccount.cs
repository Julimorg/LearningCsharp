// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Learning.OOP

// {
//     public class BankAccount
//     {
//         private decimal _balance;

//         public decimal Balance 
//         {
//             get{
//                 return Math.Round(_balance, 2);
//             }
//             set{
//                 if ( value  <  0) 
//                 throw new ArgumentException("Balance cannot be negative");
//                 _balance = value;
//             }
//         }
//         public void Deposit(decimal amount){

//             if ( amount <= 0)
//             throw new ArgumentException("Deposit amount must be positive");

//             _balance += amount ;
//         }
        
//         public void Withdraw(decimal amount){

//             if ( amount <= 0)
//             throw new ArgumentException("Withdraw amount must be positive");

//             if ( _balance < amount)
//             throw new ArgumentException("Insufficient funds");

//             _balance -= amount;
//         }
//     }
// }