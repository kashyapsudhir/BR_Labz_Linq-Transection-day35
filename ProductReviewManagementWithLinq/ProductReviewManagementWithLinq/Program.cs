using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;
using ProductReviewManagementWithLinq;

namespace ProductReviewManagementWithlinq
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello Product review Management With Linq");
            //UC-1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview()
                {
                    ProductID=1,
                    UserID=1,
                    Rating="Good",
                    Review= 5,
                    IsLike=true
                },
                 new ProductReview()
                {
                    ProductID=2,
                    UserID=3,
                    Rating="Good",
                    Review= 2,
                    IsLike=true
                },
                  new ProductReview()
                {
                    ProductID=3,
                    UserID=3,
                    Rating="Nice",
                    Review= 7,
                    IsLike=false
                },
                   new ProductReview()
                {
                    ProductID=1,
                    UserID=2,
                    Rating="bad",
                    Review= 4,
                    IsLike=true
                },
                    new ProductReview()
                {
                    ProductID=4,
                    UserID=3,
                    Rating="nice",
                    Review= 3,
                    IsLike=false
                },
                     new ProductReview()
                {
                    ProductID=5,
                    UserID=6,
                    Rating="nice",
                    Review= 5,
                    IsLike=true
                },
                      new ProductReview()
                {
                    ProductID=5,
                    UserID=6,
                    Rating="Good",
                    Review= 7,
                    IsLike=true
                },
                       new ProductReview()
                {
                    ProductID=7,
                    UserID=4,
                    Rating="bad",
                    Review= 2,
                    IsLike=false
                },
                        new ProductReview()
                {
                    ProductID=8,
                    UserID=7,
                    Rating="Good",
                    Review= 6,
                    IsLike=false
                },

            }; 
            //foreach(var list in productReviews)
            //{
            //    Console.WriteLine("ProductID:-" +list.ProductID + " " + "UserID:-" + list.UserID
            //        + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);

            //}

            Management management = new Management();
            //UC2
            // management.TopRecords(productReviewList);
            //UC3
            management.SelectedRecords(productReviewList);
        }


    }
}