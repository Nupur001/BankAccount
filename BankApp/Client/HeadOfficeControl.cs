using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Utility;
using BankApp.Business;

namespace BankApp.Client
{
    public class HeadOfficeControl
    {
        /// <summary>
        /// This shows the main menu
        /// </summary>
        public void TakeChoice()
        {
            Constants Constant = new Constants();
            Console.WriteLine(Constant.HeadControlMenu);
            try
            {
                int Choice =int.Parse(Console.ReadLine());
                HeadOffice Office = new HeadOffice();
                switch (Choice)
                {
                    case 1:
                        //Create a new Branch
                        Office.CreateBranch();
                        Console.WriteLine(Constant.HitEnter);
                        Console.ReadLine();
                        TakeChoice();
                        break;
                    case 2:
                        //Taking Branch Id to return a branch
                        Console.WriteLine(Constant.TakeBranchId);
                        var BranchId = Console.ReadLine();
                        Office.GetBranchByID(BranchId);
                        Console.WriteLine(Constant.HitEnter);
                        Console.ReadLine();
                        TakeChoice();
                        break;
                    case 3:
                        //Return all branches available
                        Office.GetAllBranches();
                        Console.WriteLine(Constant.HitEnter);
                        Console.ReadLine();
                        TakeChoice();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Input is not valid");
            }

        }
    }
}
