using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductReviewManagementWithlinq;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="Review"></param>
        //public void TopRecords(List<ProductReview> listProductReview)
        //{
        //    var recordsData =(from productReviewList  in listProductReview
        //                      orderby productReviewList.Rating 
        //                      descending select productReviewList).Take(3);

        //    foreach (var list in recordsData)
        //    {
        //        Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
        //            + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);

        //    }
        //}
        //public void SelectedRecords(List<ProductReview> listProductReview)
        //{
        //    var recordedData = from productReviewList in listProductReview
        //                       where (productReviewList.ProductID == 1 ||
        //                              productReviewList.ProductID == 4 ||
        //                              productReviewList.ProductID == 9)
        //                              && productReviewList.Review > 3
        //                       select productReviewList;
        //var recordsData = from productReviewList in listProductReview
        //                where (productReviewList.ProductID == 1 && productReviewList.Review > 3)
        //                   || (productReviewList.ProductID == 4 && productReviewList.Review > 3)
        //                   || (productReviewList.ProductID == 9 && productReviewList.Review > 3)
        //                   select productReviewList;

        //    foreach (var list in recordedData)
        //    {
        //        Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
        //            + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);

        //    }


        //}

        //UC-4
        //public void CountRecords(List<ProductReview> listProductReview)
        //{
        //    var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new
        //    { ProductID = x.Key, Count = x.Count() });

        //    foreach (var list in recordedData)
        //    {
        //        Console.WriteLine(list.ProductID+"------"+list.Count);
        //    }
        //}

        //UC-5
        //public void GetProductIDAndReview(List<ProductReview> listProductReview)
        //{
        //    Console.WriteLine("\n ProductId and review are :");
        //    var recordedData = listProductReview.Select(p => new { Id = p.ProductID, Review = p.Review }).ToList();
        //    foreach (var p in recordedData)
        //    {
        //        Console.WriteLine("Product ID=" + p.Id + " Review=" + p.Review);
        //    }
        //}

        //UC-6
        public static void DisplayProducts(List<ProductReview> listProductReview)
        {
            try
            {
                foreach (var lists in listProductReview)
                {
                    Console.WriteLine("Product id = " + lists.ProductID + "User id = " + lists.UserID + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.IsLike);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void Skip5Records(List<ProductReview> listProductReview)
        {
            Console.WriteLine("skipping 5 records");
            var recordedData = listProductReview.Skip(5).ToList();

            DisplayProducts(recordedData);
        }
       
    }
}
