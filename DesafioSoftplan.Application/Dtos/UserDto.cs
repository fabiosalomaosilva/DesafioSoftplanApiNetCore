namespace DesafioSoftplan.Services.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string LoginProvider { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string Complementar { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}