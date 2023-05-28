namespace MeuCrm.DTOs
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public bool FirstPage { get; set; }
        public bool LastPage { get; set; }
    }
}
