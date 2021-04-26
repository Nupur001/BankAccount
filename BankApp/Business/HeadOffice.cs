using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Utility;
using BankApp.Client;

namespace BankApp.Business
{
    internal class HeadOffice
    {
        public static List<Branch> Branches = new List<Branch>();//List of all the branches
        public Constants Constant = new Constants();
        /// <summary>
        /// Creates a new branch by adding a new branch id to the Branches List
        /// </summary>
        public void CreateBranch()
        {
            Branch Branc = new Branch();
            Branc.BranchId = (Branches.Count + 1).ToString();
            Branches.Add(Branc);
            Console.WriteLine(Constant.BranchAdded, Branc.BranchId);
        }

        /// <summary>
        /// Prints branch by comparing branchId
        /// </summary>
        /// <param name="branchID"></param>
        public void GetBranchByID(string branchId)
        {
            if (!Branches.Exists(branch => branch.BranchId == branchId))
            {
                Console.WriteLine(Constant.InvalidInput);
            }
            else
            {
               Branch Branc= Branches.Find(branch => branch.BranchId == branchId);
               BranchNavigation Navigation = new BranchNavigation();
               Navigation.Details(Branc);
            }
        }
        /// <summary>
        /// Prints a list of branch in the head office. i.e. Branches
        /// </summary>
        public void GetAllBranches()
        {
            if (Branches.Count == 0)
            {
                Console.WriteLine(Constant.NoBranch);
            }
            else
            {
                foreach(Branch Branc in Branches)
                {
                    Console.WriteLine(Branc.BranchId);
                }
            }
        }
    }
}
