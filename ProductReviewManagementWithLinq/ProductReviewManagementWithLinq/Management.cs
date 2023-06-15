using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviewList in listProductReview
                               where (productReviewList.ProductID == 1 ||
                                      productReviewList.ProductID == 4 ||
                                      productReviewList.ProductID == 9)
                                      && productReviewList.Review > 3
                               select productReviewList;
            //var recordsData = from productReviewList in listProductReview
            //                where (productReviewList.ProductID == 1 && productReviewList.Review > 3)
            //                   || (productReviewList.ProductID == 4 && productReviewList.Review > 3)
            //                   || (productReviewList.ProductID == 9 && productReviewList.Review > 3)
            //                   select productReviewList;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);

            }

        }
    }
}
