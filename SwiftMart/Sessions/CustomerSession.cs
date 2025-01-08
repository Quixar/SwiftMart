namespace SwiftMart.Sessions
{
    public class CustomerSession
    {
        private static CustomerSession instance;
        public static CustomerSession Instance => instance ??= new CustomerSession();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        private CustomerSession() { }
    }
}
