namespace _BookShop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get => base.Price;
            set => base.Price = value + (value * 0.30m);
        }
    }
}
