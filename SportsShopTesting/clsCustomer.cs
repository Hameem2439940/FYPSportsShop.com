namespace SportsShopTesting
{
    internal class customer
    {
        public customer()
        {
        }

        public static int CustomerID { get; internal set; }
        public string Username { get; internal set; }
        public bool VerifiedAccount { get; internal set; }
        public string EmailAddress { get; internal set; }
        public string Postcode { get; internal set; }
    }
}