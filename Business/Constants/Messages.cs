using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddSuccess = "Added succesfully.";
        public static string DeleteSuccess = "Deleted succesfully.";
        public static string UpdateSuccess = "Updated succesfully.";
        public static string ListSuccess = "Listed succesfully.";
        public static string InvalidDailyPrice = "Invalid daily rental price. Please make sure it's more than 0.";
        public static string DeliverSuccess = "Delivered successfully.";
        public static string MaxCarImageCountExceeded = "Max images that can be added has been exceeded.";
        public static string ImageNotFound = "Image couldn't be found.";
    }
}
