using System;

namespace Models
{

    public class JobReport : Base
    {
        public int Id { get; set; }
        public string NazwaPrac { get; set; }
        public DateTime DataIGodzina { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string NazwaLokalu { get; set; }
    }
}
