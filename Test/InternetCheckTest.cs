using System;

namespace Test
{
    class InternetCheckTest
    {
        public static void IsInternetCheckTest()
        {
            Console.WriteLine("If you have internet connection, enter 1, if you haven't - enter 0");
            var isUserHaveInternet = Console.ReadLine() == "0" ? false : true;
            var isInternetConnection = Core.InternetCheck.CheckForInternetConnection();
            Console.WriteLine(isInternetConnection == isUserHaveInternet ? "Test passed" : "Test failed");
        }
    }
}
