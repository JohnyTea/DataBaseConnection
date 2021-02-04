namespace DataBaseConnection
{
    public class Category
    {
        public Category(int categoryiD, string categoryName)
        {
            CategoryiD = categoryiD;
            CategoryName = categoryName;
        }

        public int CategoryiD { get; }
        public string CategoryName { get; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}