namespace Core.Entities
{
   public class Owner : EntityBase
        {
            public string FullName { get; set; }
            public string Profil { get; set; }
            public string Afatar { get; set; }
            public Address Address { get; set; }
        }
}
