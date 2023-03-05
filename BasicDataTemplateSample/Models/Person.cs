using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTemplateSample.Models
{
    public class Person
    {
        /// <summary>
        /// Gets or sets the first name of the person. You can only set this property on init.
        /// </summary>
        public string? FirstName { get; init; }

        /// <summary>
        /// Gets or sets the last name of the person. You can only set this property on init.
        /// </summary>
        public string? LastName { get; init; }

        /// <summary>
        /// Gets or sets the age of the person. You can only set this property on init.
        /// </summary>
        public int Age { get; init; }

        /// <summary>
        /// Gets or sets the sex of the person. You can only set this property on init.
        /// </summary>
        public Sex Sex { get; init; }
    }
}
