using System;


using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    public class ProductReview
    {
        public int ProductID
        {
            get;
            set;
        }
        public int UserID
        {
            get;
            set;
        }
        public string Rating
        {
            get;
            set;
        }
        public double Review
        {
            get;
            set;
        }
        public bool IsLike
        {
            get;
            set;
        }
    }
}
