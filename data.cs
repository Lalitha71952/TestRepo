using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestRepo
{
    /// &lt;summary&gt;
    /// Data class for handling data operations
    /// &lt;/summary&gt;
    public class Data
    {
        /// &lt;summary&gt;
        /// Gets or sets the unique identifier
        /// &lt;/summary&gt;
        [Key]
        public int Id { get; set; }

        /// &lt;summary&gt;
        /// Gets or sets the name
        /// &lt;/summary&gt;
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// &lt;summary&gt;
        /// Gets or sets the description
        /// &lt;/summary&gt;
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        /// &lt;summary&gt;
        /// Gets or sets the creation date
        /// &lt;/summary&gt;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// &lt;summary&gt;
        /// Gets or sets the last modified date
        /// &lt;/summary&gt;
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;

        /// &lt;summary&gt;
        /// Gets or sets whether the data is active
        /// &lt;/summary&gt;
        public bool IsActive { get; set; } = true;

        /// &lt;summary&gt;
        /// Gets or sets additional properties as key-value pairs
        /// &lt;/summary&gt;
        public Dictionary&lt;string, object&gt; Properties { get; set; } = new Dictionary&lt;string, object&gt;();

        /// &lt;summary&gt;
        /// Constructor for Data class
        /// &lt;/summary&gt;
        public Data()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        /// &lt;summary&gt;
        /// Constructor with name parameter
        /// &lt;/summary&gt;
        /// &lt;param name="name"&gt;The name of the data&lt;/param&gt;
        public Data(string name) : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// &lt;summary&gt;
        /// Updates the modified timestamp
        /// &lt;/summary&gt;
        public void UpdateModifiedTime()
        {
            ModifiedAt = DateTime.UtcNow;
        }

        /// &lt;summary&gt;
        /// Validates the data object
        /// &lt;/summary&gt;
        /// &lt;returns&gt;True if valid, false otherwise&lt;/returns&gt;
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) &amp;&amp; Name.Length &lt;= 100;
        }

        /// &lt;summary&gt;
        /// Returns a string representation of the data
        /// &lt;/summary&gt;
        /// &lt;returns&gt;String representation&lt;/returns&gt;
        public override string ToString()
        {
            return $"Data: {Name} (ID: {Id}, Active: {IsActive})";
        }
    }
}