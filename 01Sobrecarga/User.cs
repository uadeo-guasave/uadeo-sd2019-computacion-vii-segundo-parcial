using System;

namespace _01Sobrecarga
{
    /// <summary>
    /// Clase usuario
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador de la clase.
        /// </summary>
        /// <value>Valor único que identifica a cada usuario.</value>
        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Constructor de la clase sin argumentos
        /// </summary>
        public User()
        {
            GenerateIdAndCode();
        }

        private void GenerateIdAndCode()
        {
            Id = new Random().Next(1, 10000);
            Code = Guid.NewGuid().ToString();
        }

        public User(string firstName, string lastName)
        {
            // llamar al constructor sin argumentos
            GenerateIdAndCode();
            FirstName = firstName;
            LastName = lastName;
        }

        public User(string firstName, string lastName, string email)
        {
            GenerateIdAndCode();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public User(int id, string code, string firstName, string lastName, string email)
        {
            Id = id;
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nCode: {Code}\nFirstName: {FirstName}\nLastName: {LastName}\nEmail: {Email}";
        }
    }
}