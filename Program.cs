namespace Assignment3__
{
    internal class Program
    {

        #region Q03
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion#region Q04
        #region Q04
        static void PrintBookTitle(string title)
        {
            //Console.WriteLine("Book title: " + title );
        }
        #endregion
        #region Q05
        //static void AddBonusPages(int pages)
        //{
        //    //pages += 50;
        //    //Console.WriteLine("inside:"+ pages);//450
        //}
        #endregion
        #region Q06
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -=5;
        //}
        #endregion
        #region Q07
        //static void AddBonusPages( ref int pages)
        //{
        //    pages += 50;
        //    Console.WriteLine("inside:" + pages);//450
        //}
        #endregion
        #region Q08
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices= new double[] { 10.0, 12.5, 15.0 };
        //}
        #endregion
        
        static void Main(string[] args)
        {
            #region Q01
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Q02
            //int[,] shelfCopies =
            //{
            //    {3,5 }, {1,4}
            //};
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion
            #region Q03
            //PrintWelcomeMessage();
            #endregion
            #region Q04
            //PrintBookTitle("clean code");
            #endregion
            #region Q05
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine("outside:"+ pages);//400
            //// due to this is calling (passing by value - value type)
            ////the method receive the copy of the variable
            //// so he change doesn't affect the original
            #endregion
            #region Q06
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);//20.5
            //// due to arrays are reference types
            ////the mothod receive a copy of refrence ,and both refrences point to the same array in memory
            ////change inside method ,affect the original array
            #endregion
            #region Q07
            //int pages = 400;
            //AddBonusPages(ref pages);
            //Console.WriteLine("outside:" + pages);//450
            //// due to (call by refrence ) the variable by reference pass not just a copy of it 
            ///change made inside the method affect it 
            #endregion
            #region Q08
            //double[] prices = { 10.0, 4.0, 2006.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);//3
            ////ref keyword allows the method
            ////to replace the original array with new array 
            #endregion
            

        }
    }
}
