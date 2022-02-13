using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Kokos_Utility
{
    public static class WebConstants
    {
        public const string ImagePath = @"\images\product\";
        public const string SessionCart = "ShoppingCartSession";
        public const string SessionInquiryId = "InquirySession";

        public const string AdminRole = "Admin";
        public const string CustomerRole = "Customer";
        public const string EmailAdmin = "konstant.kovalenko@gmail.com";

        public const string CategoryName = "Category";
        public const string ApplicationTypeName = "ApplicationType";
        public const string Success = "Success";
        public const string Error = "Error";

        public static readonly IEnumerable<string> ListStatus = new ReadOnlyCollection<string>(
            new List<string>
            {
                StatusApproved, StatusCancelled, StatusInProcess, StatusPending, StatusRefunded, StatusShipped
            });



        /// <summary>
        /// в ожидании
        /// </summary>
        public const string StatusPending = "Pending";
        /// <summary>
        /// Одобренный
        /// </summary>
        public const string StatusApproved = "Approved";
        /// <summary>
        /// в обработке
        /// </summary>
        public const string StatusInProcess = "Processing";
        /// <summary>
        /// отправлен
        /// </summary>
        public const string StatusShipped = "Shipped";
        /// <summary>
        /// отменен
        /// </summary>
        public const string StatusCancelled = "Cancelled";
        /// <summary>
        /// возмещено (возвращены средства)
        /// </summary>
        public const string StatusRefunded = "Refunded";
    }
}
