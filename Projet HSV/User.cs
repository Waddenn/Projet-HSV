namespace Projet_HSV
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }

    public class Appointment
    {
        public string Speciality { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; } = "En attente";
        public string DoctorConfirmed { get; set; }

        public bool Equals(Appointment other)
        {
            return this.Speciality == other.Speciality &&
                   this.Date == other.Date &&
                   this.Time == other.Time;
        }
    }

}
