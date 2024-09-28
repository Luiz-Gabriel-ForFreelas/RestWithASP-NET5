﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETErudio.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("addres")]
        public string Addres { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

    }
}
