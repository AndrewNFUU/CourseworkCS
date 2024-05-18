using System;

namespace CourseWorkCS
{
    [Serializable]
    public class Person
    {
        private string _firstName;
        private string _lastName;

        #region constructors
        public Person() {}

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region properties
        public string FirstName
        {
            get => _firstName; 
            set
            {
                if (string.IsNullOrEmpty(value) || value.Contains(" "))
                {
                    throw new ArgumentException("First name cannot be empty or contains spaces.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be at least 2 characters long.");
                }

                if (ContainsDigits(value))
                {
                    throw new ArgumentException("First name cannot contain digits.");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Contains(" "))
                {
                    throw new ArgumentException("Last name cannot be empty or contains spaces.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name must be at least 2 characters long.");
                }

                if (ContainsDigits(value))
                {
                    throw new ArgumentException("Last name cannot contain digits.");
                }

                _lastName = value;
            }
        }
        #endregion

        public virtual string ShowInfo()
        {
            return $" First name: {_firstName}  " +
                $" Last name: {_lastName}  ";    
        }

        private bool ContainsDigits(string input)
        {
            //input.Any(char.IsDigit)
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true; 
                }
            }

            return false; 
        }

        public override string ToString()
        {
            return $"First name: {_firstName}  Last name: {_lastName}  ";
        }
    }
}
