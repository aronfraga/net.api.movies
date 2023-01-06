﻿using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models.Dtos {
    public class UserDto {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
