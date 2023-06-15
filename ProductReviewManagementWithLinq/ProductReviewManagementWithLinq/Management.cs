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
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordsData =(from productReviews  in listProductReview
                              orderby productReviews.Rating 
                              descending select productReviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID
                    + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);

            }
        }
    }
}
