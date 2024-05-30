namespace Solid.API.Models
{
    public class ClientPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoomId { get; set; }
        public DateOnly EntryDate { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
